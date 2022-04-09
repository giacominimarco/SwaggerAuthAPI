using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SwaggerAPI.Models;

namespace SwaggerAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class GetController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            string message = "Successfull";
            return Ok(new Response { Status = "Sucesso", Message = message });
        }
    }
}
