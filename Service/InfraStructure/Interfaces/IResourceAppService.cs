using Service.InfraStructure.Dto.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.InfraStructure.Interfaces
{
    public interface IResourceAppService<T>
    {
        public T Get(T inputImage);
        public bool Upload(T resource, bool merge = false);
        public bool Delete(string name);
    }
}
