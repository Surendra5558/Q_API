FROM mcr.microsoft.com/dotnet/sdk:9.0.303 AS build
WORKDIR /app

COPY Dcube.Questionnaire.Api/DCube.Questionnaire.Api.csproj /.Dcube.Questionnaire.Api/
RUN cd Dcube.Questionnaire.Api && dotnet restore
COPY . .
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app


# Copy published app from build stage
COPY --from=build /app/publish .

# Expose Cloud Run's default port
EXPOSE 8080

# Start the application
ENTRYPOINT ["dotnet", "DCube.Questionnaire.Api.dll"]




