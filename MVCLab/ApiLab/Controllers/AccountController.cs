using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiLab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost("Login")]
        public IActionResult Login(string username, string password)
        {
            var token = new TokenService().Generate(username, password);

            if (token is null)
            {
                return BadRequest("Invalid Credentials");
            }
            return Ok(token);
        }
    }
}
