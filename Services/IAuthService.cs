using Back_Vueapp.DTOs.Auth;

namespace Back_Vueapp.Services
{
    public interface IAuthService
    {
        Task<AuthResponseDto?> AuthenticateAsync(LoginDto dto);
        Task<AuthResponseDto?> RegisterAsync(RegisterDto dto);
    }
}
