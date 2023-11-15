using AutoMapper;
using SilvRestaurant.Core.Application.Interfaces.Repositories;
using SilvRestaurant.Core.Application.Interfaces.Services;
using SilvRestaurant.Core.Application.ViewModels.DisheIngredient;
using SilvRestaurant.Core.Application.ViewModels.Dishes;
using SilvRestaurant.Core.Domain.Entities;

namespace SilvRestaurant.Core.Application.Services
{
    public class DisheService : GenericService<SaveDisheViewModel, DisheViewModel, Dishe>, IDisheService
    {
        private readonly IDisheIngredientService _disheIngredientService;
        private readonly IDisheRepository _disheRepository;
        private readonly IMapper _mapper;
        public DisheService(IMapper mapper, IDisheRepository disheRepository, IDisheIngredientService disheIngredientService) : base(mapper, disheRepository)
        {
            _disheIngredientService = disheIngredientService;
            _disheRepository = disheRepository;
            _mapper = mapper;
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
            var dishes = await _disheRepository.GetAllWithIncluideAsync(new List<string> { "DisheIngredients.Ingredient", "Category"});
            return dishes.Select(dish => new DisheViewModel
            {
                Id = dish.Id,
                AmountOfPeople = dish.AmountOfPeople,
                Category = dish.Category.Name,
                Price = dish.Price,
                Name = dish.Name,
                Ingredients = dish.DisheIngredients.Select(ingredient => ingredient.Ingredient.Name).ToList(),
            }).ToList();
        }

        public override async Task Update(SaveDisheViewModel model, int id)
        {
            await _disheIngredientService.ClearDisheIngredient(id);

            foreach(var ingredient in model.IdIngredients)
            {
                var disheIngredien = new SaveDisheIngredientViewModel()
                {
                    IdDishe = id,
                    IdIngredient = ingredient
                };
                await _disheIngredientService.Add(disheIngredien);
            }
            await base.Update(model, id);
        }
        public async Task<DisheViewModel> GetDisheById(int id)
        {
            var dishes = await _disheRepository.GetAllWithIncluideAsync(new List<string> { "DisheIngredients.Ingredient", "Category" });

            return dishes.Select(dish => new DisheViewModel
            {
                Id = dish.Id,
                AmountOfPeople = dish.AmountOfPeople,
                Category = dish.Category.Name,
                Price = dish.Price,
                Name = dish.Name,
                Ingredients = dish.DisheIngredients.Select(ingredient => ingredient.Ingredient.Name).ToList(),
            }).FirstOrDefault(x => x.Id == id);
        }
    }
}
