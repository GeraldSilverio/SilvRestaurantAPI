﻿using SilvRestaurant.Core.Application.ViewModels.DisheIngredient;
using SilvRestaurant.Core.Domain.Entities;

namespace SilvRestaurant.Core.Application.Interfaces.Services
{
    public interface IDisheIngredientService : IGenericService<SaveDisheIngredientViewModel, DisheIngredientViewModel, DisheIngredient>
    {
        Task ClearDisheIngredient(int idDishe);
    }
}
