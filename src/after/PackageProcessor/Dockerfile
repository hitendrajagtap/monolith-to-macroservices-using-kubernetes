FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["PackageProcessor/PackageProcessor.csproj", "PackageProcessor/"]

RUN dotnet restore "PackageProcessor/PackageProcessor.csproj"
COPY . .
WORKDIR "/src/PackageProcessor"
RUN dotnet build "PackageProcessor.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PackageProcessor.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PackageProcessor.dll"]