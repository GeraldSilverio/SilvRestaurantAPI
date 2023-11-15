using Microsoft.EntityFrameworkCore;
using SilvRestaurant.Core.Application.Interfaces.Repositories;
using SilvRestaurant.Core.Domain.Entities;
using SilvRestaurant.Infraestructure.Persistence.Context;

namespace SilvRestaurant.Infraestructure.Persistence.Repositories
{
    public class DisheIngredientRepository : GenericRepositoryAsync<DisheIngredient>, IDisheIngredientRepository
    {
        private readonly ApplicationContext _dbContext;
        public DisheIngredientRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task ClearDisheIngredient(int idDishe)
        {
            var dishes = _dbContext.DisheIngredients.Where(x => x.IdDishe == idDishe);

            foreach (var dishe in dishes)
            {
                _dbContext.Remove(dishe);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
