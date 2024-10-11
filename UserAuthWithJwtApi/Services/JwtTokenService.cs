using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UserAuthWithJwtApi.Models;

namespace UserAuthWithJwtApi.Services
{
    public class JwtTokenService : ITokenService
    {
        private readonly IOptions<JwtOptions> _options;

        private SymmetricSecurityKey Key => new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_options.Value.SigningKey));

        public JwtTokenService(IOptions<JwtOptions> options)
        {
            _options = options;
        }

        public string CreateToken(AppUser user)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.GivenName, user.UserName),
            };

            var credentials = new SigningCredentials(Key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(7),
                SigningCredentials = credentials,
                Issuer = _options.Value.Issuer,
                Audience = _options.Value.Audience,
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
