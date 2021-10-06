#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["WebApps/webStatus/webStatus.csproj", "WebApps/webStatus/"]
RUN dotnet restore "WebApps/webStatus/webStatus.csproj"
COPY . .
WORKDIR "/src/WebApps/webStatus"
RUN dotnet build "webStatus.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "webStatus.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "webStatus.dll"]
