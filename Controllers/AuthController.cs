using Microsoft.AspNetCore.Mvc;
using Back_Vueapp.DTOs.Auth;
using Back_Vueapp.Services;

namespace Back_Vueapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<ActionResult<AuthResponseDto>> Login(LoginDto dto)
        {
            var response = await _authService.AuthenticateAsync(dto);
            if (response == null) return Unauthorized("Invalid credentials.");

            return Ok(response);
        }

        [HttpPost("register")]
        public async Task<ActionResult<AuthResponseDto>> Register(RegisterDto dto)
        {
            var response = await _authService.RegisterAsync(dto);
            if (response == null) return BadRequest("Username already exists.");

            return Ok(response);
        }
    }
}
