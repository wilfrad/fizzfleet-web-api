using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.InfraStructure.Dto.Catalog
{
    public class ProductPublishDto : ProductPostDto
    {
        public string[] Covers { get; set; }
        public string[] Thumbnails { get; set; }
        public string Description { get; set; }
        public string[] Specs { get; set; }
        public bool Active { get; set; }
    }
}
