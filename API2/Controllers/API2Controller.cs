using Microsoft.AspNetCore.Mvc;

namespace API2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class API2Controller : Controller
    {

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await Task.Delay(2000);

            return Ok("Response from API2");
        }
    }
}
