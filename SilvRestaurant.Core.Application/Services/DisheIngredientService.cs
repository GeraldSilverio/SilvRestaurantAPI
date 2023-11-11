using AutoMapper;
using SilvRestaurant.Core.Application.Interfaces.Repositories;
using SilvRestaurant.Core.Application.Interfaces.Services;
using SilvRestaurant.Core.Application.ViewModels.DisheIngredient;
using SilvRestaurant.Core.Domain.Entities;

namespace SilvRestaurant.Core.Application.Services
{
    public class DisheIngredientService : GenericService<SaveDisheIngredientViewModel, DisheIngredientViewModel, DisheIngredient>, IDisheIngredientService
    {
        public DisheIngredientService(IMapper mapper, IGenericRepositoryAsync<DisheIngredient> repository) : base(mapper, repository)
        {
        }
    }
}
