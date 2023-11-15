using Microsoft.EntityFrameworkCore;
using SilvRestaurant.Core.Application.Interfaces.Repositories;
using SilvRestaurant.Core.Application.ViewModels.Ingredient;
using SilvRestaurant.Core.Domain.Entities;
using SilvRestaurant.Infraestructure.Persistence.Context;

namespace SilvRestaurant.Infraestructure.Persistence.Repositories
{
    public class IngredientReposity : GenericRepositoryAsync<Ingredient>, IIngredientRepository
    {
        private readonly ApplicationContext _dbContext;
        public IngredientReposity(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Ingredient>> GetAllById(int id)
        {
            return await _dbContext.Ingredients.Where(x => x.Id == id).ToListAsync();
        }
    }
}
