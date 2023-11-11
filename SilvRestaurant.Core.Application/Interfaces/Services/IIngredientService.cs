using SilvRestaurant.Core.Application.ViewModels.Ingredient;
using SilvRestaurant.Core.Domain.Entities;

namespace SilvRestaurant.Core.Application.Interfaces.Services
{
    public interface IIngredientService:IGenericService<SaveIngredientViewModel, IngredientViewModel,Ingredient>
    {
    }
}
