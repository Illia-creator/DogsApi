using DogsApi.Core;
using DogsApi.Core.Contracts;
using Microsoft.EntityFrameworkCore;

namespace DogsApi.Api.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddScoped<IDataContext>(provider => provider.GetService<DataContext>());
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

            application.UseAuthorization();

            application.MapControllers();

            application.Run();
        }
    }
}
