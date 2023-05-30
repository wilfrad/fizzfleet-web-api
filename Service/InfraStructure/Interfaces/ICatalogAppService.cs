using Service.Data.Models;
using Service.InfraStructure.Dto.Catalog;

namespace Service.InfraStructure.Interfaces
{
    public interface ICatalogAppService
    {
        public List<ProductPostDto> GetByCategory(string[] categories, int offset, int limit);
        public List<ProductPostDto> Get(int offset, int limit);
    }
}
