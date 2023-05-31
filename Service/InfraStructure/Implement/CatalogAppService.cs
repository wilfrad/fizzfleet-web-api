using Microsoft.EntityFrameworkCore;
using Service.Data;
using Service.Data.Models;
using Service.InfraStructure.Dto.Catalog;
using Service.InfraStructure.Dto.Resource;
using Service.InfraStructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.InfraStructure.Implement
{
    public class CatalogAppService : ICatalogAppService
    {
        private readonly FizzFleetDbContext _context = new FizzFleetDbContext();

        private List<ProductPostDto> BuildPosts(IQueryable<Publicacion> result)
        {
            List<ProductPostDto> posts = result.Select(post =>
                            new ProductPostDto()
                            {
                                PublishId = post.Id,
                                Cover = new ImageDto() 
                                    {
                                        fileName = post.PublicacionImagen
                                            .Select(thumbnail => thumbnail.Miniatura).ToString()
                                },
                                Title = post.Titulo,
                                Price = post.Precio,
                                Categories = post.PublicacionCategoria
                                    .Select(category => category.FkCategoriaProductoNavigation.FkCategoriaNavigation.Etiqueta)
                                    .Take(3)
                                    .ToArray()
                            }
                        ).ToList();
            return posts;
        }

        public List<ProductPostDto> Get(int offset, int limit)
        {
            try
            {
                var result = _context.Publicacion
                        .Where(publi =>
                            publi.Diponibilidad &&
                            publi.Id >= offset && publi.Id <= limit);
                List<ProductPostDto> posts = BuildPosts(result);
                return posts;
            }
            catch (NullReferenceException nre) { }

            return null;
        }

        public List<ProductPostDto> GetByCategory(string[] categories, int offset, int limit)
        {
            throw new NotImplementedException();
        }
    }
}
