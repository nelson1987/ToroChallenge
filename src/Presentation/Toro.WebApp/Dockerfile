##See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
#
#FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
## BEGIN MODIFICATION - Node is needed for development (but not production)
#RUN curl -sL https://deb.nodesource.com/setup_10.x | bash -
#RUN apt-get install --assume-yes nodejs
## END MODIFICATION
#WORKDIR /app
#EXPOSE 80
#
#FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
#WORKDIR /src
#COPY ["Toro.WebApp/Toro.WebApp.csproj", "Toro.WebApp/"]
#RUN dotnet restore "Toro.WebApp/Toro.WebApp.csproj"
#COPY . .
#WORKDIR "/src/Toro.WebApp"
#RUN dotnet build "Toro.WebApp.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "Toro.WebApp.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "Toro.WebApp.dll"]

FROM node:10.15-alpine AS client
EXPOSE 4200 49153
USER node
RUN mkdir /home/node/.npm-global
ENV PATH=/home/node/.npm-global/bin:$PATH
ENV NPM_CONFIG_PREFIX=/home/node/.npm-global
RUN npm install -g @angular/cli@8.1.0
WORKDIR /app
CMD ["ng", "serve", "--port", "4200", "--host", "0.0.0.0", "--disable-host-check", "--poll", "2000"]