using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.InfraStructure.Interfaces
{
    public interface IResourceAppService
    {
        public byte[] Get(string name);
        public bool Upload(byte[] resource, bool merge = false);
        public bool Delete(string name);
    }
}
