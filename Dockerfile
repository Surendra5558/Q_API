# Stage 1 — Build
FROM mcr.microsoft.com/dotnet/sdk:9.0.303 AS build
WORKDIR /src

# Copy csproj and restore dependencies
COPY Dcube.Questionnaire.Api/DCube.Questionnaire.Api.csproj Dcube.Questionnaire.Api/
WORKDIR /src/Dcube.Questionnaire.Api
RUN dotnet restore

# Copy all source code and publish
COPY . /src
RUN dotnet publish -c Release -o /app/publish

# Stage 2 — Runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app

# Copy published output from build stage
COPY --from=build /app/publish .

# Expose Cloud Run's default port
EXPOSE 8080

# Start the application
ENTRYPOINT ["dotnet", "DCube.Questionnaire.Api.dll"]
