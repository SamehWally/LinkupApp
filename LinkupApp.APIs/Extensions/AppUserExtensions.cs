using LinkupApp.APIs.DTOs;
using LinkupApp.APIs.Entities;
using LinkupApp.APIs.Interfaces;

namespace LinkupApp.APIs.Extensions
{
    public static class AppUserExtensions
    {
        public static UserDto ToDto(this AppUser user, ITokenService tokenService)
        {
            return new UserDto
            {
                Id = user.Id,
                DisplayName = user.DisplayName,
                Email = user.Email,
                Token = tokenService.CreateToken(user)
            };
        }
    }
}
