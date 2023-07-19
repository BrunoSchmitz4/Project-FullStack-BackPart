using Microsoft.AspNetCore.Mvc;
using PrimeiraWebAPI.Application.Services;
//using PrimeiraWebAPI.Domain.Models;
namespace PrimeiraWebAPI.Controllers
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
                var token = TokenService.GenerateToken(new Domain.Models.EmployeeAggregate.Employee());
                return Ok(token);
            }

            return BadRequest("Usuário ou senha inválido.");
        }
    }
}
