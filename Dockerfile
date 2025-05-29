FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build-env
WORKDIR /app

# Copy everything first
COPY . ./

# Restore and build from the correct directory (lowercase 'back')
RUN dotnet restore back/IvyScans.API/IvyScans.API.csproj
RUN dotnet publish back/IvyScans.API/IvyScans.API.csproj -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build-env /app/out .

# Expose port
EXPOSE 8080
ENV ASPNETCORE_URLS=http://*:8080

ENTRYPOINT ["dotnet", "IvyScans.API.dll"]