using SilvRestaurant.Core.Application.Interfaces.Repositories;
using SilvRestaurant.Core.Domain.Entities;
using SilvRestaurant.Infraestructure.Persistence.Context;

namespace SilvRestaurant.Infraestructure.Persistence.Repositories
{
    public class IngredientReposity : GenericRepositoryAsync<Ingredient>, IIngredientRepository
    {
        public IngredientReposity(ApplicationContext dbContext) : base(dbContext)
        {
        }
    }
}
