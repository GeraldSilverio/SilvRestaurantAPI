using Microsoft.AspNetCore.Mvc;
using SilvRestaurant.Core.Application.Interfaces.Services;
using SilvRestaurant.Core.Application.ViewModels.Dishes;

namespace SilvRestaurant.WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    public class DisheController : BaseApiController
    {
        private readonly IDisheService _disheService;

        public DisheController(IDisheService disheService)
        {
            _disheService = disheService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DisheViewModel))]

        public async Task<IActionResult> Get()
        {
            try
            {
                var dishes = await _disheService.GetAll();
                if (dishes.Count == 0)
                {
                    return NoContent();
                }
                return Ok(dishes);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SaveDisheViewModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> Post([FromBody] SaveDisheViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                await _disheService.Add(model);
                return Created("Created", model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
