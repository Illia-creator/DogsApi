using DogsApi.Persistence;
using DogsApi.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace DogsApi.Api.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddServices(this WebApplicationBuilder builder, IConfiguration configuration) 
        {
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IDogRepository, DogRepository>();
            builder.Services.AddControllers();
            builder.Services.AddDbContext<DataContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            });
            return builder.Services;
        }

        public static void AddApplication(this WebApplication application)
        {
            if (application.Environment.IsDevelopment())
            {
                application.UseSwagger();
                application.UseSwaggerUI();
            }

            application.UseHttpsRedirection();

            application.UseRouting();

            application.UseAuthorization();

            application.MapControllers();

            application.Run();
        }
    }
}
