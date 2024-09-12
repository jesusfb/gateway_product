# Usar la imagen base de ASP.NET para la aplicación
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Usar la imagen base de SDK para compilar y restaurar las dependencias
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ProductService/ProductService.csproj", "ProductService/"]

# Restaurar las dependencias del proyecto
RUN dotnet restore "ProductService/ProductService.csproj"

# Copiar todos los archivos y construir el proyecto
COPY . .
WORKDIR "/src/ProductService"
RUN dotnet build "ProductService.csproj" -c Release -o /app/build

# Publicar la aplicación
FROM build AS publish
RUN dotnet publish "ProductService.csproj" -c Release -o /app/publish

# Configuración final para ejecutar la aplicación
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProductService.dll"]
