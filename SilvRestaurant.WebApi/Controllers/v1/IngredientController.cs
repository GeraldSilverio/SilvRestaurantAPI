using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SilvRestaurant.Core.Application.Interfaces.Services;
using SilvRestaurant.Core.Application.ViewModels.Ingredient;

namespace SilvRestaurant.WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize(Roles = "Admin")]
    public class IngredientController : BaseApiController
    {
        private readonly IIngredientService _ingredientService;

        public IngredientController(IIngredientService ingredientService)
        {
            _ingredientService = ingredientService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IngredientViewModel))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get()
        {
            try
            {
                var ingredients = await _ingredientService.GetAll();
                if (ingredients.Count == 0)
                {
                    return NoContent();
                }
                return Ok(ingredients);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }
        [HttpGet("GetById")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IngredientViewModel))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var ingredient = await _ingredientService.GetById(id);
                if (ingredient is null)
                {
                    return NoContent();
                }
                return Ok(ingredient);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SaveIngredientViewModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Post(SaveIngredientViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(model);
                }
                await _ingredientService.Add(model);
                return StatusCode(StatusCodes.Status201Created, "Ingrediente creado con exito");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IngredientViewModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> Put(SaveIngredientViewModel model, int id)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                await _ingredientService.Update(model, id);
                return Ok(model);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
