using Microsoft.AspNetCore.Mvc;
using SilvRestaurant.Core.Application.Dtos;
using SilvRestaurant.Core.Application.Interfaces.Services;

namespace SilvRestaurant.WebApi.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("authenticate")]

        public async Task<IActionResult> AuthenticateAsync(AuthenticationRequest request)
        {
            return Ok(await _accountService.AuthenticateAsync(request));
        }
        
        [HttpPost("register")]

        public async Task<IActionResult> RegisterAsync(RegisterRequest request)
        {
            var origin = Request.Headers["origin"];
            return Ok(await _accountService.RegisterBasicUserAsync(request,origin));
        }
    }
}
