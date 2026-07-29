using Microsoft.AspNetCore.Mvc;

namespace KirbyFortneyWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { name = "Kirby Fortney" });
        }
    }
}
