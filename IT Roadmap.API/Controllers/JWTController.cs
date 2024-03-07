using IT_Roadmap.Core.Data;
using IT_Roadmap.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IT_Roadmap.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JWTController : ControllerBase
    {
        private readonly IJWTService jwtservice;
        public JWTController(IJWTService jwtservice)
        {
            this.jwtservice = jwtservice;
        }

        [HttpPost]
        public IActionResult Auth([FromBody] User user)
        {
            var token = jwtservice.Auth(user);
            if (token == null)
            {
                return Unauthorized();
            }
            else
            {
                return Ok(token);
            }
        }
    }
}
