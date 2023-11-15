using AutoMapper;
using SilvRestaurant.Core.Application.Interfaces.Repositories;
using SilvRestaurant.Core.Application.Interfaces.Services;
using SilvRestaurant.Core.Application.ViewModels.DisheIngredient;
using SilvRestaurant.Core.Domain.Entities;

namespace SilvRestaurant.Core.Application.Services
{
    public class DisheIngredientService : GenericService<SaveDisheIngredientViewModel, DisheIngredientViewModel, DisheIngredient>, IDisheIngredientService
    {
        private readonly IDisheIngredientRepository _disheIngredientRepository;
        public DisheIngredientService(IMapper mapper, IDisheIngredientRepository disheIngredientRepository) : base(mapper, disheIngredientRepository)
        {
            _disheIngredientRepository = disheIngredientRepository;
        }

        public async Task ClearDisheIngredient(int idDishe)
        {
            await _disheIngredientRepository.ClearDisheIngredient(idDishe);
        }
    }
}
