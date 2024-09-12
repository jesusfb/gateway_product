using Microsoft.EntityFrameworkCore;
using ProductService.Data;

namespace ProductService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Configura el servicio de EF Core
            builder.Services.AddDbContext<ProductContext>(options =>
                options.UseInMemoryDatabase("ProductDatabase"));

            // Agregar servicios al contenedor.
            builder.Services.AddControllers();
            // Configurar Swagger para la documentación de la API
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configurar el pipeline de solicitudes HTTP.
            if (app.Environment.IsDevelopment())
            {
               
            }
            app.UseSwagger();
            app.UseSwaggerUI();
            // Deshabilitar la redirección HTTPS para evitar problemas en el contenedor
            // app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            // Asegurarse de que la aplicación escuche en todas las interfaces y en el puerto 80
            //app.Run("http://0.0.0.0:80");
            app.Run();
        }
    }
}
