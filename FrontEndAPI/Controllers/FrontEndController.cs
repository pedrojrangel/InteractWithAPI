using FrontEndAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FrontEndAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FrontEndController : Controller
    {
        private readonly IAPIServices _aPIServices;
        private readonly IConfiguration _configuration;

        public FrontEndController(IAPIServices aPIServices, IConfiguration configuration)
        {
            _aPIServices = aPIServices;
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var api2 = _aPIServices.GetResponseFromApi(_configuration["APIsURL:API2"]);
                var api3 = _aPIServices.GetResponseFromApi(_configuration["APIsURL:API3"]);

                await Task.WhenAll(api2, api3);

                return Ok(new
                {
                    API2 = await api2,
                    API3 = await api3
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
          
        }



        [HttpPost]
        public async Task<IActionResult> Post([FromBody] string value)
        {

            return Ok("Post received: " + value);
        }
    }
}
