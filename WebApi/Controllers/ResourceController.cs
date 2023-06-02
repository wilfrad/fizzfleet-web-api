using Microsoft.AspNetCore.Mvc;
using Service.InfraStructure.Dto.Resource;
using Service.InfraStructure.Implement;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ResourceController : Controller
    {
        [Route("image/{filename}")]
        [HttpGet]
        public IActionResult GetImage([FromQuery] string fileName)
        {
            ImageResourceAppService service = new();
            ImageDto image = new ImageDto() { fileName = fileName };
            var result = service.Get(image);

            if (result.Image is not null) return File(service.Get(image).Image, service.fileType);

            return NotFound();
        }
    }
}