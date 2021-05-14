
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["ToroChallenge.WebApi/ToroChallenge.WebApi.csproj", "ToroChallenge.WebApi/"]
RUN dotnet restore "ToroChallenge.WebApi/ToroChallenge.WebApi.csproj"
COPY . .
WORKDIR "/src/ToroChallenge.WebApi"
RUN dotnet build "ToroChallenge.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ToroChallenge.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ToroChallenge.WebApi.dll"]