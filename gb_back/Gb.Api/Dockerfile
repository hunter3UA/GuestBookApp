FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Gb.Api/Gb.Api.csproj", "Gb.Api/"]
COPY ["Gb.Infrastructure/Gb.Infrastructure.csproj", "Gb.Infrastructure/"]
COPY ["Gb.Application/Gb.Application.csproj", "Gb.Application/"]
COPY ["Gb.Domain/Gb.Domain.csproj", "Gb.Domain/"]
RUN dotnet restore "Gb.Api/Gb.Api.csproj"
COPY . .
WORKDIR "/src/Gb.Api"
RUN dotnet build "Gb.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Gb.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Gb.Api.dll"]