FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["ChnageTrackerLearn/ChnageTrackerLearn.csproj", "ChnageTrackerLearn/"]
RUN dotnet restore "ChnageTrackerLearn/ChnageTrackerLearn.csproj"
COPY . .
WORKDIR "/src/ChnageTrackerLearn"
RUN dotnet build "ChnageTrackerLearn.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ChnageTrackerLearn.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ChnageTrackerLearn.dll"]
