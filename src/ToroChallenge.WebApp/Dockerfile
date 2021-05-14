#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["ToroChallenge.WebApp/ToroChallenge.WebApp.csproj", "ToroChallenge.WebApp/"]
RUN dotnet restore "ToroChallenge.WebApp/ToroChallenge.WebApp.csproj"
COPY . .
WORKDIR "/src/ToroChallenge.WebApp"
RUN dotnet build "ToroChallenge.WebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ToroChallenge.WebApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ToroChallenge.WebApp.dll"]