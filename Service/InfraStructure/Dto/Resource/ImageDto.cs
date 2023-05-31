using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.InfraStructure.Dto.Resource
{
    public class ImageDto
    {
        public string fileName { get; set; }
        public byte[]? Thumbnail { get; set; }
        public byte[] Image { get; set; }
    }
}
