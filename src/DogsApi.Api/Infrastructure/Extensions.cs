using DogsApi.Api.Middlewares;
using DogsApi.Persistence;
using DogsApi.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace DogsApi.Api.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddScoped<IDogRepository, DogRepository>();
            services.AddControllers();
            services.AddSingleton<GlobalExceptionHandlingMiddleware>();
            services.AddDbContext<DataContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            });
            return services;
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

            application.UseMiddleware<GlobalExceptionHandlingMiddleware>();

            application.MapControllers();

            application.Run();
        }
    }
}
