using Microsoft.AspNetCore.Mvc;
using PokeAPIWeb.Application.Services;
//using PokeAPIWeb.Domain.Models;

namespace PokeAPIWeb.Controllers
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : Controller
    {
        [HttpPost]
        public IActionResult Auth(string username, string password)
        {
            if (username == "Bruno" && password == "123456")
            {
                var token = TokenService.GenerateToken(new Domain.Models.PokemonAggregate.Pokemon());
                return Ok(token);
            }

            return BadRequest("Usuário ou senha inválido.");
        }
    }
}
