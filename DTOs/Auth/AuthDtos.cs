namespace Back_Vueapp.DTOs.Auth
{
    public class LoginDto
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
    }

    public class RegisterDto
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
    }

    public class AuthResponseDto
    {
        public required string Token { get; set; }
        public required string Username { get; set; }
        public required string Role { get; set; }
    }
}
