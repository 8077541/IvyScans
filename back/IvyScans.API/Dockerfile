FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY . .
WORKDIR /src/IvyScans.API
RUN dotnet restore "IvyScans.API.csproj"
RUN dotnet publish "IvyScans.API.csproj" -c Release -o /app/publish