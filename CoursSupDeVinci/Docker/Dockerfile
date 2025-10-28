FROM mcr.microsoft.com/dotnet/runtime:9.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["CoursSupDeVinci/CoursSupDeVinci.csproj", "CoursSupDeVinci/"]
RUN dotnet restore "CoursSupDeVinci/CoursSupDeVinci.csproj"
COPY . .
WORKDIR "/src/CoursSupDeVinci"
RUN dotnet build "./CoursSupDeVinci.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./CoursSupDeVinci.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CoursSupDeVinci.dll"]
