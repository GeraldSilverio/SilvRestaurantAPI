using SilvRestaurant.Core.Application.Interfaces.Repositories;
using SilvRestaurant.Core.Domain.Entities;
using SilvRestaurant.Infraestructure.Persistence.Context;

namespace SilvRestaurant.Infraestructure.Persistence.Repositories
{
    public class DisheIngredientRepository : GenericRepositoryAsync<DisheIngredient>, IDisheIngredientRepository
    {
        public DisheIngredientRepository(ApplicationContext dbContext) : base(dbContext)
        {
        }
    }
}
