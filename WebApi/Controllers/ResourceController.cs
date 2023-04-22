using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ResourceController : Controller
    {
        [Route("image/{id}")]
        [HttpGet]
        public async Task<IActionResult> GetImage([FromQuery] int id)
        {
            return Ok();
        }

        [Route("document/{id}")]
        [HttpGet]
        public async Task<IActionResult> GetDocument([FromQuery] int id)
        {
            return Ok();
        }
    }
}