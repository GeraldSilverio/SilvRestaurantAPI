using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SilvRestaurant.Infraestructure.Persistence.Context;

namespace SilvRestaurant.Infraestructure.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            #region DbContext
            if (configuration.GetValue<bool>("UseInMemoryDataBase"))
            {
                services.AddDbContext<ApplicationContext>(options => options.UseInMemoryDatabase("ApplicationDb"));
            }
            else
            {
                services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                m => m.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)));
            }
            #endregion



        }

    }
}