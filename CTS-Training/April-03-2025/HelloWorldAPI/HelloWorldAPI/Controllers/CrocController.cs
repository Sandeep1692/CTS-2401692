using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrocController : ControllerBase
    {
        [HttpGet]
        [Route("hello")]
        public async Task<IActionResult> Getcroc()
        {
            var temp = "Hello From CrocController";
            return Ok(temp);
        }
    }
}