# Build stage
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build

COPY . .
RUN dotnet publish "OSDemo.HttpApi.Host.csproj" -c Release -o /app

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0

WORKDIR /app
COPY --from=build /app ./
ENV ASPNETCORE_URLS=http://+:80
ENTRYPOINT ["dotnet", "OSDemo.HttpApi.Host.dll"]