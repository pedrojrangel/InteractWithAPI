using Microsoft.AspNetCore.Mvc;

namespace API3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class API3Controller : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await Task.Delay(3000);
            return Ok("Response from API3");
        }
    }
}
