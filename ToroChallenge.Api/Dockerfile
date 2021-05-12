#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
#WORKDIR /app
#EXPOSE 80
#EXPOSE 443
#
#FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
#WORKDIR /src
#COPY ["ToroChallenge.Api/ToroChallenge.Api.csproj", "ToroChallenge.Api/"]
#RUN dotnet restore "ToroChallenge.Api/ToroChallenge.Api.csproj"
#COPY . .
#WORKDIR "/src/ToroChallenge.Api"
#RUN dotnet build "ToroChallenge.Api.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "ToroChallenge.Api.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "ToroChallenge.Api.dll"]
#

FROM microsoft/aspnetcore AS base
WORKDIR /app

# Copiar csproj e restaurar dependencias
COPY *.csproj ./
RUN dotnet restore

# Build da aplicacao
COPY . ./
RUN dotnet publish -c Release -o out

# Build da imagem
FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "ToroChallenge.Api.dll"]