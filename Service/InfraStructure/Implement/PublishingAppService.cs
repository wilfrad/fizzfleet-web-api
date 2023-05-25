using Microsoft.EntityFrameworkCore;
using Service.Data;
using Service.InfraStructure.Dto.Catalog;
using Service.InfraStructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.InfraStructure.Implement
{
    public class PublishingAppService : IPublishingAppService
    {
        private readonly FizzFleetDbContext _context = new FizzFleetDbContext();

        public List<ProductPostDto> Get(int offset, int limit)
        {
            try
            {
                var result = _context.Publicacion
                        .Where(publi =>
                            publi.Diponibilidad &&
                            publi.Id >= offset && publi.Id <= limit)
                        .Include(publiCover =>
                            publiCover.PublicacionImagen.Where(coverMain => coverMain.Principal))
                        .Include(publiCategories =>
                            publiCategories.PublicacionCategoria).Take(3);
                List<ProductPostDto> posts = BuildPosts(result);
                return posts;
            } catch(NullReferenceException nre) {}

            return null;
        }

        public List<ProductPostDto> GetByCategory(string[] categories, int offset, int limit)
        {
            throw new NotImplementedException();
        }

        public ProductPublishedDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        private List<ProductPostDto> BuildPosts (IQueryable<Data.Models.Publicacion> result)
        {
            List<ProductPostDto> posts = result.Select(post =>
                            new ProductPostDto()
                            {
                                PublishId = post.Id,
                                Cover = post.PublicacionImagen
                                    .Select(thumbnail => thumbnail.Miniatura).ToString(),
                                Title = post.Titulo,
                                Price = post.Precio,
                                Categories = post.PublicacionCategoria
                                    .Select(category => category.FkCategoriaProductoNavigation.FkCategoriaNavigation.Etiqueta).ToArray()
                            }).ToList();
            return posts;
        }
    }
}
