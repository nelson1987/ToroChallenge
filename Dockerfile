FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["ToroChallenge.Api/ToroChallenge.Api.csproj", "ToroChallenge.Api/"]
RUN dotnet restore "ToroChallenge.Api/ToroChallenge.Api.csproj"
COPY . .
WORKDIR "/src/ToroChallenge.Api"
RUN dotnet build "ToroChallenge.Api.csproj" -c Release -o /app/build

WORKDIR "/src/ToroChallenge.Models.Tests"
RUN dotnet test "ToroChallenge.Models.Tests.csproj" -c Release -o /app/test

FROM build AS publish
RUN dotnet publish "ToroChallenge.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ToroChallenge.Api.dll"]