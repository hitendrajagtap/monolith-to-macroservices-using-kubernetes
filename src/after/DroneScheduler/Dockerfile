FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["DroneScheduler/DroneScheduler.csproj", "DroneScheduler/"]

RUN dotnet restore "DroneScheduler/DroneScheduler.csproj"
COPY . .
WORKDIR "/src/DroneScheduler"
RUN dotnet build "DroneScheduler.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DroneScheduler.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DroneScheduler.dll"]