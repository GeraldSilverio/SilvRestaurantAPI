using SilvRestaurant.Core.Application.ViewModels.Ingredient;
using SilvRestaurant.Core.Domain.Entities;

namespace SilvRestaurant.Core.Application.Interfaces.Repositories
{
    public interface IIngredientRepository:IGenericRepositoryAsync<Ingredient>
    {
    }
}
