using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Service.Data;
using Service.InfraStructure.Dto.Catalog;

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
                Cover = "aaaaa",
                Title = "title",
                Price = 20_000,
                Categories = new string[] {"a", "b", "c", "d"}
            },
            new ProductPostDto()
            {
                PublishId = 2,
                Cover = "aaaaa",
                Title = "title",
                Price = 20_000,
                Categories = new string[] {"a", "b", "c", "d"}

            },
            new ProductPostDto()
            {
                PublishId = 3,
                Cover = "aaaaa",
                Title = "title",
                Price = 20_000,
                Categories = new string[] {"a", "b", "c", "d"}

            }
        };

        private FizzFleetDbContext _context = new();

        //[Route("{first-count}-{amount}")]
        [HttpGet]
        public async Task<ActionResult<List<ProductPostDto>>> GetCatalog(/*FromQuery] int firstCount, [FromQuery] int amount*/)
        {
            /*var productPosts = await _context.Publicacions
                                    .Join(_context.Productos, pub => pub.FkProducto, pro => pro.Id)
                                    .Join(_context.PublicacionImagens, pub => pub.Id, pubImg => pubImg.FkPublicación)
                                    .Where(publish => publish.Id >= firstCount && publish.Id <= amount) 
                                    .Select(product =>
                                        new ProductPostDto()
                                        {
                                            Title = product.Nombre,
                                            Price = product.ValorUnitario
                                        }
                                    ).ToListAsync();*/
            return Ok(posts);
        }

        [Route("{id}")]
        [HttpGet]
        public async Task<IActionResult> GetPublished([FromQuery] int id)
        {
            var productPublish = await DbContext.instance.Publicacions
                                    .Where(publish => publish.Id == id)
                                    .Select(publish => 
                                        new ProductPublishDto()
                                        {
                                    
                                        }
                                    ).SingleOrDefaultAsync();
            return Ok(productPublish);
        }
    }
}