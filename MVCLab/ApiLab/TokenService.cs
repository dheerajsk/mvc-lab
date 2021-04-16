using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ApiLab
{
    public class TokenService
    {
        public string Generate(string username, string password)
        {
            if (username == "admin" && password == "password")
            {
                var key = Encoding.ASCII.GetBytes("this is a secret key I am using fot authentication of my test api");

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[] {
                        new Claim(ClaimTypes.NameIdentifier, "admin")
                    }),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature),
                    Expires = DateTime.Now.AddHours(2)
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var createdToken = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(createdToken);
            }
            else
            {
                return null;
            }
        }
    }
}
