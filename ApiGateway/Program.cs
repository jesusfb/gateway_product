using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace ApiGateway
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Configurar el archivo de configuración para Ocelot
            builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
            builder.Services.AddOcelot();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configurar el pipeline de solicitudes HTTP
            if (app.Environment.IsDevelopment())
            {
                
            }

            app.UseSwagger();
            app.UseSwaggerUI();
            // Deshabilitar redirección HTTPS para evitar problemas en el contenedor Docker
            // app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            // Configurar Ocelot para manejar las solicitudes HTTP
            await app.UseOcelot();

            // Asegurar que la aplicación escuche en todas las interfaces y en el puerto 80
            //app.Run("http://0.0.0.0:80");
            app.Run();
        }
    }
}
