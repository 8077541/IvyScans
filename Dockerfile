# Use the official .NET 9 SDK image
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build-env
WORKDIR /app

# Copy everything and debug structure
COPY . ./

# Debug: Show the actual directory structure
RUN find . -name "*.csproj" -type f
RUN ls -la
RUN ls -la IvyScans/ || echo "IvyScans folder not found"
RUN ls -la IvyScans/Back/ || echo "IvyScans/Back folder not found"
RUN ls -la IvyScans/Back/IvyScans.API/ || echo "IvyScans/Back/IvyScans.API folder not found"

# Try to find the actual project file
RUN find . -name "*.csproj" -exec echo "Found project file: {}" \;

# Restore and build (update path based on debug output)
RUN dotnet restore IvyScans/Back/IvyScans.API/IvyScans.API.csproj
RUN dotnet publish IvyScans/Back/IvyScans.API/IvyScans.API.csproj -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build-env /app/out .

# Expose port
EXPOSE 8080
ENV ASPNETCORE_URLS=http://*:8080

ENTRYPOINT ["dotnet", "IvyScans.API.dll"]