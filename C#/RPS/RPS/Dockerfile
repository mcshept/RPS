FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["RPS/RPS.csproj", "RPS/"]
RUN dotnet restore "RPS/RPS.csproj"
COPY . .
WORKDIR "/src/RPS"
RUN dotnet build "RPS.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RPS.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RPS.dll"]
