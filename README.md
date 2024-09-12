
# 🛠️ MicroservicesLab_G3

Este proyecto es una práctica de microservicios que utiliza Docker y un API Gateway para integrar varios servicios independientes. Está diseñado para funcionar tanto en aplicaciones móviles como web, facilitando una arquitectura escalable y distribuida.

## 🚀 Características

- **Microservicios**: El proyecto se divide en múltiples microservicios independientes, cada uno encargado de una responsabilidad específica.
  - **OrderService**: Servicio para la gestión de pedidos.
  - **ProductService**: Servicio para la gestión de productos.
  - **ApiGateway**: Intermediario que maneja las solicitudes y las distribuye a los microservicios correspondientes.
  
- **API Gateway**: Se utiliza para gestionar el enrutamiento entre los microservicios y los clientes (web/móvil).
  
- **Docker**: Los servicios se ejecutan en contenedores Docker para facilitar la orquestación y el despliegue.

- **Compatibilidad con aplicaciones móviles y web**: La API Gateway permite consumir los microservicios tanto desde aplicaciones móviles como web, garantizando una experiencia unificada.

## 📦 Tecnologías Utilizadas

- **C# y .NET**: Lenguaje y framework principal para la implementación de los microservicios.
- **Docker**: Para contenerizar y orquestar los microservicios.
- **API Gateway**: Gestión de la comunicación entre los servicios y los clientes.
- **Docker Compose**: Para manejar la configuración y la orquestación de múltiples contenedores Docker.

## 📂 Estructura del Proyecto

- **ApiGateway/**: Contiene el código del gateway que gestiona las peticiones de los clientes.
- **OrderService/**: Servicio que maneja la lógica de los pedidos.
- **ProductService/**: Servicio que gestiona la lógica de los productos.
- **docker-compose.yml**: Archivo de configuración para orquestar los contenedores Docker de los microservicios.
- **.dockerignore**: Configuración para excluir archivos innecesarios de los contenedores Docker.

## 🛠️ Requisitos del Sistema

- **Docker** instalado en tu máquina.
- **.NET 6.0 SDK** o superior.
- **Visual Studio 2022** (opcional para desarrollo y depuración).

## ⚙️ Instalación y Configuración

1. **Clona el repositorio**:

   ```bash
   git clone https://github.com/usuario/MicroservicesLab_G3.git
   cd MicroservicesLab_G3
   ```

2. **Construye los contenedores Docker**:

   Asegúrate de tener Docker instalado y ejecuta el siguiente comando para construir y levantar los servicios:

   ```bash
   docker-compose up --build
   ```

3. **Accede a los servicios**:

   - La API Gateway estará disponible en `http://localhost:5000`.
   - El servicio de pedidos (`OrderService`) y el servicio de productos (`ProductService`) se gestionan a través del API Gateway.

## 📱💻 Uso

1. **Aplicaciones móviles y web**: Puedes consumir los servicios a través del API Gateway desde cualquier aplicación móvil o web.
2. **CRUD de Pedidos y Productos**: Utiliza herramientas como Postman o cURL para realizar operaciones CRUD en los servicios de pedidos y productos.

## 🧑‍💻 Contribuciones

Las contribuciones son bienvenidas. Si tienes ideas para mejorar el proyecto, no dudes en hacer un fork y abrir un pull request.

1. Haz un fork del proyecto.
2. Crea una nueva rama (`git checkout -b feature/nueva-funcionalidad`).
3. Realiza tus cambios (`git commit -am 'Agregada nueva funcionalidad'`).
4. Haz push a tu rama (`git push origin feature/nueva-funcionalidad`).
5. Abre un pull request.

## 📜 Licencia

Este proyecto está bajo la Licencia MIT - consulta el archivo [LICENSE](LICENSE) para más detalles.
