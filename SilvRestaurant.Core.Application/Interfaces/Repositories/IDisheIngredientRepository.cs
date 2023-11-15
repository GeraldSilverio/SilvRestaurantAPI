using SilvRestaurant.Core.Domain.Entities;

namespace SilvRestaurant.Core.Application.Interfaces.Repositories
{
    public interface IDisheIngredientRepository:IGenericRepositoryAsync<DisheIngredient>
    {
        Task ClearDisheIngredient(int idDishe);
    }
}
