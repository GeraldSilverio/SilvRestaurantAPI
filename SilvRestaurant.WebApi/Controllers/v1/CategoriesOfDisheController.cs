using Microsoft.AspNetCore.Mvc;
using SilvRestaurant.Core.Application.Interfaces.Services;
using SilvRestaurant.Core.Application.ViewModels.CategoryOfDishe;

namespace SilvRestaurant.WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    public class CategoriesOfDisheController : BaseApiController
    {
        private readonly ICategoryOfDisheService _categoryOfDisheService;

        public CategoriesOfDisheController(ICategoryOfDisheService categoryOfDisheService)
        {
            _categoryOfDisheService = categoryOfDisheService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK,Type = typeof(CategoryOfDisheViewModel))]

        public async Task<IActionResult> Get()
        {
            try
            {
                var categories = await _categoryOfDisheService.GetAll();
                if(categories.Count == 0)
                {
                    return NoContent();
                }
                return Ok(categories);

            }catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
