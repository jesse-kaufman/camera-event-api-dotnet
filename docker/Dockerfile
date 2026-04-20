# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o /app/publish --no-restore

# Stage 2: Image
FROM mcr.microsoft.com/dotnet/aspnet:10.0-alpine AS runtime
WORKDIR /app

COPY --from=build /app/publish ./

VOLUME /app/data

ENV ASPNETCORE_URLS=http://+:5155
ENV ASPNETCORE_ENVIRONMENT=Production
ENV ConnectionStrings__Db="Data Source=/app/data/database.sqlite"

EXPOSE 5155

ENTRYPOINT ["dotnet", "CameraEventApi.dll"]
