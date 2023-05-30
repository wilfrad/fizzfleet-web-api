using Microsoft.AspNetCore.Mvc;
using Service.InfraStructure.Implement;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ResourceController : Controller
    {
        private ImageResourceAppService _resources = new();
        [Route("image/{filename}")]
        [HttpGet]
        public IActionResult GetImage([FromQuery] string fileName)
        {
            return File(_resources.Get(fileName), _resources.fileType);
        }
    }
}