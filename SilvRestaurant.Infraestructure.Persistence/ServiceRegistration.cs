using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SilvRestaurant.Core.Application.Interfaces.Repositories;
using SilvRestaurant.Infraestructure.Persistence.Context;
using SilvRestaurant.Infraestructure.Persistence.Repositories;

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

            #region Repositories

            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            services.AddTransient<IIngredientRepository, IngredientReposity>();
            services.AddTransient<ITableRepository, TableRepository>();
            services.AddTransient<ICategoryOfDisheRepository, CategoryOfDisheRepository>();
            services.AddTransient<IDisheIngredientRepository, DisheIngredientRepository>();
            services.AddTransient<IDisheRepository, DisheRepository>();
            #endregion



        }

    }
}