FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CS4125.csproj", "."]
RUN dotnet restore "CS4125.csproj"
COPY . .
RUN dotnet build "CS4125.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CS4125.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CS4125.dll"]
