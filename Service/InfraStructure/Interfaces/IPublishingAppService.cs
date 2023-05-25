using Service.InfraStructure.Dto.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.InfraStructure.Interfaces
{
    public interface IPublishingAppService
    {
        public ProductPublishedDto GetById(int id);
        public List<ProductPostDto> GetByCategory(string[] categories, int offset, int limit);
        public List<ProductPostDto> Get(int offset, int limit);
    }
}