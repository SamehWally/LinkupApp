using LinkupApp.APIs.Entities;

namespace LinkupApp.APIs.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
