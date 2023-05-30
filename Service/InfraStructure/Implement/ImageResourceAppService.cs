using Service.Data;
using Service.InfraStructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.InfraStructure.Implement
{
    public class ImageResourceAppService : IResourceAppService
    {
        private readonly string _rootPath = "./../../db-data/images";
        public readonly string fileType = "image/png";

        public byte[] Get(string name)
        {
            var filePath = Path.Combine(_rootPath, name);
            return File.ReadAllBytes(filePath);
        }

        public bool Upload(byte[] resource, bool merge = false)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string name)
        {
            throw new NotImplementedException();
        }
    }
}
