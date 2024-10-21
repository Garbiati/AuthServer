FROM mcr.microsoft.com/dotnet/sdk:8.0-jammy AS publish

WORKDIR /src
COPY ["AuthServer.Api/AuthServer.Api.csproj", "AuthServer.Api/"]
COPY ["AuthServer.Application/AuthServer.Application.csproj", "AuthServer.Application/"]
COPY ["AuthServer.Domain/AuthServer.Domain.csproj", "AuthServer.Domain/"]
COPY ["AuthServer.Domain.Tests/AuthServer.Domain.Tests.csproj", "AuthServer.Domain.Tests/"]
COPY ["AuthServer.Infra.Data/AuthServer.Infra.Data.csproj", "AuthServer.Infra.Data/"]
COPY ["AuthServer.Infra.IoC/AuthServer.Infra.IoC.csproj", "AuthServer.Infra.IoC/"]

RUN dotnet restore "AuthServer.Api/"
RUN dotnet tool restore

COPY . .

WORKDIR "/src/AuthServer.Api"
RUN dotnet publish "AuthServer.Api.csproj" -c Release -o /app/publish --no-restore
WORKDIR "/src"

# Etapa de execução
FROM mcr.microsoft.com/dotnet/aspnet:8.0-jammy AS final
WORKDIR /app
COPY --from=publish /app/publish .

RUN chmod -R a+w /app
USER app
ENV ASPNETCORE_URLS=http://+:8000
EXPOSE 8000
ENTRYPOINT ["dotnet", "AuthServer.Api.dll"]
