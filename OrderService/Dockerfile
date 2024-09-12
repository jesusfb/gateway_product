# Usar la imagen base de SDK para compilar y restaurar las dependencias
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["OrderService/OrderService.csproj", "OrderService/"]

# Restaurar las dependencias del proyecto
RUN dotnet restore "OrderService/OrderService.csproj"

# Copiar todos los archivos y construir el proyecto
COPY . .
WORKDIR "/src/OrderService"
RUN dotnet build "OrderService.csproj" -c Release -o /app/build

# Publicar la aplicación
FROM build AS publish
RUN dotnet publish "OrderService.csproj" -c Release -o /app/publish

# Usar la imagen base de ASP.NET para la aplicación
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OrderService.dll"]
