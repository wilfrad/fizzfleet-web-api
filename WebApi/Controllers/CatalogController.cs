﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [Route("{offset}-{limit}")]
        [HttpGet]
        public async Task<ActionResult<List<ProductPostDto>>> GetCatalog
            ([FromQuery] int offSet, [FromQuery] int limit)
        {
            return Ok(posts);
        }

        [Route("{id}")]
        [HttpGet]
        public async Task<IActionResult> GetPublished([FromQuery] int id)
        {
            return Ok(posts[id]);
        }
    }
}