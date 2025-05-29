FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build-env
WORKDIR /app

# Copy csproj and restore dependencies
COPY IvyScans/Back/IvyScans.API/*.csproj ./IvyScans/Back/IvyScans.API/
RUN dotnet restore IvyScans/Back/IvyScans.API/IvyScans.API.csproj

# Copy everything else and build
COPY . ./
RUN dotnet publish IvyScans/Back/IvyScans.API/IvyScans.API.csproj -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build-env /app/out .

# Expose port
EXPOSE 8080
ENV ASPNETCORE_URLS=http://*:8080

ENTRYPOINT ["dotnet", "IvyScans.API.dll"]