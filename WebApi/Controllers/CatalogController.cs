using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Service.InfraStructure.Dto.Catalog;
using Service.InfraStructure.Implement;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : Controller
    {
        private List<ProductPostDto> posts = new List<ProductPostDto>()
        {
            new ProductPostDto()
            {
                PublishId = 1,
                Cover = null,
                Title = "title",
                Price = 20_000,
                Categories = new string[] {"a", "b", "c", "d"}
            }
        };
        private CatalogAppService _service = new();

        [Route("{offset}-{limit}")]
        [HttpGet]
        public IActionResult GetCatalog
            ([FromQuery] int offSet, [FromQuery] int limit)
        {
            var result = _service.Get(offSet, limit);
            if (result is not null) return Ok(result);

            return NotFound();
        }

        [HttpGet]
        public IActionResult GetCatalog()
        {
            return Ok(posts);
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetPublished([FromQuery] int id)
        {
            return Ok(posts[id]);
        }
    }
}