using Microsoft.Extensions.DependencyInjection;
using SilvRestaurant.Core.Application.Interfaces.Services;
using SilvRestaurant.Core.Application.Services;
using System.Reflection;

namespace SilvRestaurant.Core.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            #region Services
            services.AddTransient(typeof(IGenericService<,,>), typeof(GenericService<,,>));
            services.AddTransient<IIngredientService, IngredientService>();
            services.AddTransient<ITableService, TableService>();
            services.AddTransient<ICategoryOfDisheService, CategoryOfDisheService>();

            #endregion

        }
    }
}