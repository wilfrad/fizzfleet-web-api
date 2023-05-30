using Service.Helper;
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
        public GeneralResponse<ProductPublishedDto> GetById(int id);
        public GeneralResponse<List<ProductPublishedDto>> GetByBrand(string brand);
        public GeneralResponse<List<ProductPublishedDto>> GetByAuthor(string author);
        public GeneralResponse<List<ProductPublishedDto>> Get(int offset, int limit);
        public GeneralResponse<ProductPublishedDto> Create(ProductPublishedDto published);
        public GeneralResponse<ProductPublishedDto> Update(ProductPublishedDto published);
        public GeneralResponse<ProductPublishedDto> Delete(ProductPublishedDto published);
    }
}