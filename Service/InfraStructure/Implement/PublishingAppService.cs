using Microsoft.EntityFrameworkCore;
using Service.Data;
using Service.Helper;
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
        public GeneralResponse<ProductPublishedDto> Create(ProductPublishedDto published)
        {
            throw new NotImplementedException();
        }

        public GeneralResponse<ProductPublishedDto> Delete(ProductPublishedDto published)
        {
            throw new NotImplementedException();
        }

        public GeneralResponse<List<ProductPublishedDto>> Get(int offset, int limit)
        {
            throw new NotImplementedException();
        }

        public GeneralResponse<List<ProductPublishedDto>> GetByAuthor(string author)
        {
            throw new NotImplementedException();
        }

        public GeneralResponse<List<ProductPublishedDto>> GetByBrand(string brand)
        {
            throw new NotImplementedException();
        }

        public GeneralResponse<ProductPublishedDto> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public GeneralResponse<ProductPublishedDto> Update(ProductPublishedDto published)
        {
            throw new NotImplementedException();
        }
    }
}
