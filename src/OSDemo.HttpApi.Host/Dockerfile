FROM mcr.microsoft.com/dotnet/aspnet:9.0

WORKDIR /src
COPY . .
RUN dotnet publish "OSDemo.HttpApi.Host.csproj" -c Release -o /app
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:80
ENTRYPOINT ["dotnet", "OSDemo.HttpApi.Host.dll"]