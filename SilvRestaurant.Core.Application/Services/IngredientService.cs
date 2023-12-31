﻿using AutoMapper;
using SilvRestaurant.Core.Application.Interfaces.Repositories;
using SilvRestaurant.Core.Application.Interfaces.Services;
using SilvRestaurant.Core.Application.ViewModels.Ingredient;
using SilvRestaurant.Core.Domain.Entities;

namespace SilvRestaurant.Core.Application.Services
{
    public class IngredientService : GenericService<SaveIngredientViewModel, IngredientViewModel, Ingredient>, IIngredientService
    {
        private readonly IIngredientRepository _ingredientRepository;
        private readonly IMapper _mapper;
        public IngredientService(IMapper mapper, IIngredientRepository ingredientRepository) : base(mapper, ingredientRepository)
        {
            _ingredientRepository = ingredientRepository;
            _mapper = mapper;
        }

        public async Task<List<IngredientViewModel>> GetAllById(int id)
        {
            return _mapper.Map<List<IngredientViewModel>>(await _ingredientRepository.GetAllById(id));
        }
    }
}
