#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["ToroChallenge.Api/ToroChallenge.Api.csproj", "ToroChallenge.Api/"]
COPY ["Dominio/ToroChallenge.TransferenciaContexto.Domain/ToroChallenge.TransferenciaContexto.Domain.csproj", "Dominio/ToroChallenge.TransferenciaContexto.Domain/"]
COPY ["Dominio/ToroChallenge.Domain/ToroChallenge.Domain.csproj", "Dominio/ToroChallenge.Domain/"]
COPY ["Dominio/ToroChallenge.PapelContexto.Domain/ToroChallenge.PapelContexto.Domain.csproj", "Dominio/ToroChallenge.PapelContexto.Domain/"]
RUN dotnet restore "ToroChallenge.Api/ToroChallenge.Api.csproj"
COPY . .
WORKDIR "/src/ToroChallenge.Api"
RUN dotnet build "ToroChallenge.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ToroChallenge.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ToroChallenge.Api.dll"]