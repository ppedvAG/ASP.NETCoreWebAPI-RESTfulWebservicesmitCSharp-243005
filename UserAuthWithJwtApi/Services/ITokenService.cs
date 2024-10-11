using UserAuthWithJwtApi.Models;

namespace UserAuthWithJwtApi.Services
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}