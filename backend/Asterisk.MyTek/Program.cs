using Microsoft.EntityFrameworkCore;

namespace Asterisk.MyTek;

public class Program
{
    public static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        // adds the necessary services for web API controllers to your application.
        builder.Services.AddControllers();

        builder.Services.AddDbContext<MyDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

        // Adds services required to generate the Swagger / OpenAPI specification document
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        WebApplication app = builder.Build();
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.MapControllers(); // MapControllers configures the web API controller actions in your app as endpoints
        app.Run();
    }
}