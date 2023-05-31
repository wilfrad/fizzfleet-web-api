using Service.InfraStructure.Dto.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.InfraStructure.Dto.Catalog
{
    public class ProductPostDto
    {
        public int PublishId { get; set; }
        public ImageDto Cover { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string[] Categories { get; set; }
    }
}
