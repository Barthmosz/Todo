using Microsoft.AspNetCore.Mvc;

namespace Todo.API.Controllers.HealthCheck
{
    [Route("v1/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Check()
        {
            return Ok();
        }
    }
}
