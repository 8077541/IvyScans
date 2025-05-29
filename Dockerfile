FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build-env
WORKDIR /app

# Copy everything first
COPY . ./

# Debug: Show what files we have
RUN echo "=== Directory contents ===" && ls -la
RUN echo "=== Back directory ===" && ls -la Back/
RUN echo "=== API directory ===" && ls -la Back/IvyScans.API/

# Restore and build from the correct directory
RUN dotnet restore back/IvyScans.API/IvyScans.API.csproj
RUN dotnet publish back/IvyScans.API/IvyScans.API.csproj -c Release -o out

# Debug: Show what was built
RUN echo "=== Build output ===" && ls -la out/

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build-env /app/out .

# Debug: Show what files are in the runtime image
RUN echo "=== Runtime files ===" && ls -la

# Expose port
EXPOSE 8080
ENV ASPNETCORE_URLS=http://*:8080

ENTRYPOINT ["dotnet", "IvyScans.API.dll"]