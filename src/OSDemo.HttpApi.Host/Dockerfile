# Build stage CAPA 1
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build

COPY . .
WORKDIR /src/OSDemo.HttpApi.Host
RUN dotnet publish "OSDemo.HttpApi.Host.csproj" -c Release -o /app

# Runtime stage CAPA 2
FROM mcr.microsoft.com/dotnet/aspnet:9.0

WORKDIR /app
COPY --from=build /app ./
ENV ASPNETCORE_URLS=http://+:80
ENTRYPOINT ["dotnet", "OSDemo.HttpApi.Host.dll"]