using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Core_API.Models;
using Core_API.Services;
using System.Threading.Tasks;

namespace Core_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;
        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        [ActionName("Register")]
        public async Task<IActionResult> RegisterAsync(RegisterUser user)
        {
            var response = await _authService.RegisterNewUserAsync(user);
            return Ok(response);
        }

        [HttpPost]
        [ActionName("Login")]
        public async Task<IActionResult> LoginAsync(LoginUser user)
        {
            var response = await _authService.AutheticateAsync(user);
            return Ok(response);
        }
    }
}
