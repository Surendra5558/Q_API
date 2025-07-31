using Dcube.Questionnaire.Api.ServiceDefaults;
using DCube.Questionnaire.Api.Models;
using DCube.Questionnaire.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.OData;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using System.IdentityModel.Tokens.Jwt;
using System.IO.Compression;
using System.Text;
using DCube.Questionnaire.Api.Extensions;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
//builder.Host.UseSerilog((context, configuration) => configuration.ReadFrom.Configuration(context.Configuration));
builder.AddServiceDefaults();

_ = double.TryParse(builder.Configuration["Tokens:AccessTokenExpiryInMinutes"], out var expireMinutes);
var issuer = builder.Configuration["Tokens:Issuer"]!;
var audience = builder.Configuration["Tokens:Audience"]!;
var key = builder.Configuration["Tokens:Key"]!;

// Add services to the container.

builder.Services.AddResponseCompression(options =>
{
    options.EnableForHttps = true;
    options.Providers.Add<BrotliCompressionProvider>();
});
builder.Services.Configure<BrotliCompressionProviderOptions>(options =>
{
    options.Level = CompressionLevel.SmallestSize;
});

builder.Services.AddAuthentication(opt =>
    {
        opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = issuer,
            ValidAudience = audience,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key))
        };
    })
    .AddPolicyScheme("DefaultScheme", JwtBearerDefaults.AuthenticationScheme, options =>
    {
        options.ForwardDefaultSelector = context =>
        {
            var authHeader = context.Request.Headers["Authorization"].FirstOrDefault();
            if (authHeader?.StartsWith("Bearer ") == true)
            {
                var jwtHandler = new JwtSecurityTokenHandler();
                var token = jwtHandler.ReadJwtToken(authHeader.Substring("Bearer ".Length));

                if (token.ValidTo >= DateTime.UtcNow)
                    return JwtBearerDefaults.AuthenticationScheme;

                return JwtBearerDefaults.AuthenticationScheme;
            }
            return JwtBearerDefaults.AuthenticationScheme;
        };
    });

builder.Services.AddAuthorization(options =>
{
    var defaultAuthorizationPolicyBuilder = new AuthorizationPolicyBuilder(
        JwtBearerDefaults.AuthenticationScheme);
    defaultAuthorizationPolicyBuilder = defaultAuthorizationPolicyBuilder.RequireAuthenticatedUser();
    options.DefaultPolicy = defaultAuthorizationPolicyBuilder.Build();
});

builder.Services.AddCors(options =>
{
    // this defines a CORS policy called "default"
    options.AddPolicy("default", policy =>
    {
        policy.WithOrigins((builder.Configuration["AllowedHosts"] == null ||
                            string.IsNullOrEmpty(builder.Configuration["AllowedHosts"])
            ? builder.Configuration["AllowedHosts"]
            : "*") ?? "*").AllowAnyOrigin().AllowAnyHeader();
    });
});

builder.Services.AddControllers()
    .AddOData(
        opt => opt.AddRouteComponents("v1", EdmModelBuilder.GetModels())
            .EnableQueryFeatures(maxTopValue: 2)
            .SetMaxTop(100)
            .SkipToken()
            .Select()
            .Filter()
            .OrderBy()
            .Count()
            .Expand()
    );

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(gen =>
{
    gen.IgnoreObsoleteProperties();
    gen.DescribeAllParametersInCamelCase();
    gen.CustomSchemaIds(type => type.FullName);
    gen.SwaggerDoc("v1", new OpenApiInfo { Title = "DCube.Questionnaire", Version = "v1" });

    gen.TagActionsBy(api =>
    {
        if (api.GroupName != null)
        {
            return [api.GroupName];
        }

        if (api.ActionDescriptor is ControllerActionDescriptor controllerActionDescriptor)
        {
            {
                return [controllerActionDescriptor.ControllerName];
            }
        }
        throw new InvalidOperationException("Unable to determine tag for endpoint.");
    });

    gen.DocInclusionPredicate((name, api) => true);

    gen.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "bearer"
    });
    gen.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
        }
    });
});

builder.Services.AddDbContext<QuestionnaireDbContext>(options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
            sqlServerOptionsAction: sqlOptions =>
            {
                sqlOptions.EnableRetryOnFailure(maxRetryCount: 1,
                    maxRetryDelay: TimeSpan.FromSeconds(10),
                    errorNumbersToAdd: null);
                sqlOptions.MigrationsAssembly(typeof(QuestionnaireDbContext).Assembly.FullName);
            });
    },
    ServiceLifetime.Transient);

builder.Services.AddDependency();

var app = builder.Build();

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapOpenApi();
}

app.UseCors("default");
app.UseHttpsRedirection();
app.UseResponseCompression();
app.UseAuthorization();

app.MapControllers();

app.Run();