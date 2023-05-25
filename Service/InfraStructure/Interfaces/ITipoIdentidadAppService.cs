using Service.InfraStructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.InfraStructure.Interfaces
{
    public interface ITipoIdentidadAppService
    {
        public TipoIdentidadDto GetById(int id);
        public List<TipoIdentidadDto> GetAll();
        public bool Create(TipoIdentidadDto document);
        public bool Update(TipoIdentidadDto document);
        public bool Delete(int id);
    }
}
