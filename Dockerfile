# Use the official .NET 9 SDK image
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build-env
WORKDIR /app

# Copy just the project file first for better caching
COPY Back/IvyScans.API/IvyScans.API.csproj Back/IvyScans.API/
RUN dotnet restore Back/IvyScans.API/IvyScans.API.csproj

# Copy everything else and build
COPY . ./
RUN dotnet publish Back/IvyScans.API/IvyScans.API.csproj -c Release -o out --no-restore

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build-env /app/out .

# Expose port
EXPOSE 8080
ENV ASPNETCORE_URLS=http://*:8080

ENTRYPOINT ["dotnet", "IvyScans.API.dll"]