using AutoMapper;
using SilvRestaurant.Core.Application.Interfaces.Repositories;
using SilvRestaurant.Core.Application.Interfaces.Services;
using SilvRestaurant.Core.Application.ViewModels.DisheIngredient;
using SilvRestaurant.Core.Application.ViewModels.Dishes;
using SilvRestaurant.Core.Application.ViewModels.Ingredient;
using SilvRestaurant.Core.Domain.Entities;

namespace SilvRestaurant.Core.Application.Services
{
    public class DisheService : GenericService<SaveDisheViewModel, DisheViewModel, Dishe>, IDisheService
    {
        private readonly IDisheIngredientService _disheIngredientService;
        private readonly IDisheRepository _disheRepository;
        private readonly IMapper _mapper;
        private readonly IIngredientService _ingredientService;
        public DisheService(IMapper mapper, IDisheRepository disheRepository, IDisheIngredientService disheIngredientService, IIngredientService ingredientService) : base(mapper, disheRepository)
        {
            _disheIngredientService = disheIngredientService;
            _disheRepository = disheRepository;
            _mapper = mapper;
            _ingredientService = ingredientService;
        }

        public override async Task<SaveDisheViewModel> Add(SaveDisheViewModel model)
        {
            var dishe = await base.Add(model);
            foreach (var ingredient in model.IdIngredients)
            {
                var disheingredient = new SaveDisheIngredientViewModel()
                {
                    IdDishe = dishe.Id,
                    IdIngredient = ingredient

                };
                await _disheIngredientService.Add(disheingredient);
            }
            return dishe;
        }

        public override async Task<List<DisheViewModel>> GetAll()
        {
            var dishes = await _disheRepository.GetAllWithIncluideAsync(new List<string> { "DisheIngredients", "Category" });
             return dishes.Select(dish => new DisheViewModel
            {
                Id = dish.Id,
                AmountOfPeople = dish.AmountOfPeople,
                Category = dish.Category.Name,
                Price = dish.Price,
                Name = dish.Name,
                Ingredients = _mapper.Map<List<IngredientViewModel>>(dish.DisheIngredients)

            }).ToList();

            
        }
    }
}
