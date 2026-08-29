FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY TecnoGas.Web/*.csproj ./TecnoGas.Web/
RUN dotnet restore ./TecnoGas.Web/TecnoGas.Web.csproj
COPY TecnoGas.Web/. ./TecnoGas.Web/
WORKDIR /src/TecnoGas.Web
RUN dotnet publish -c Release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app
COPY --from=build /app ./
EXPOSE 8080
ENTRYPOINT ["dotnet", "TecnoGas.Web.dll"]