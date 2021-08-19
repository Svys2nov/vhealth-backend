FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/Svys2nov.VHealth.Vehicles.API/Svys2nov.VHealth.Vehicles.API.csproj", "Svys2nov.VHealth.Vehicles.API/"]
RUN dotnet restore "Svys2nov.VHealth.Vehicles.API/Svys2nov.VHealth.Vehicles.API.csproj"
COPY src/ .
WORKDIR "/src/Svys2nov.VHealth.Vehicles.API"
RUN dotnet build "Svys2nov.VHealth.Vehicles.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Svys2nov.VHealth.Vehicles.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Svys2nov.VHealth.Vehicles.API.dll"]
