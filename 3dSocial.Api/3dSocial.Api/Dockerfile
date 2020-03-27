#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["3dSocial.Api/3dSocial.Api.csproj", "3dSocial.Api/"]
RUN dotnet restore "3dSocial.Api/3dSocial.Api.csproj"
COPY . .
WORKDIR "/src/3dSocial.Api"
RUN dotnet build "3dSocial.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "3dSocial.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "3dSocial.Api.dll"]