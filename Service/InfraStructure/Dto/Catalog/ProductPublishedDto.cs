using Service.InfraStructure.Dto.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.InfraStructure.Dto.Catalog
{
    public class ProductPublishedDto : ProductPostDto
    {
        public ImageDto[] Images { get; set; }
        public string Description { get; set; }
        public string[] Specs { get; set; }
        public bool Active { get; set; }
    }
}
