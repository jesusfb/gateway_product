using Microsoft.EntityFrameworkCore;
using OrderService.Data;

namespace OrderService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Configura el servicio de EF Core
            builder.Services.AddDbContext<OrderContext>(options =>
                options.UseInMemoryDatabase("OrderDatabase"));

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

            // Deshabilitar redirección HTTPS para evitar problemas en el contenedor Docker.
            // app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            // Asegurar que la aplicación escuche en todas las interfaces y en el puerto 80.
            //app.Run("http://0.0.0.0:80");
            app.Run();
        }
    }
}
