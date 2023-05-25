using Service.Data;
using Service.Data.Models;
using Service.Helper;
using Service.InfraStructure.Dto;
using Service.InfraStructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.InfraStructure.Implement
{
    public class TipoIdentidadAppService : ITipoIdentidadAppService
    {
        private readonly FizzFleetDbContext _context = new FizzFleetDbContext();

        public bool Create(TipoIdentidadDto document)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<TipoIdentidadDto> GetAll()
        {
            var result = _context.TipoIdentidad.Where(doc => doc.Estado == true).ToList();
            var documents = new List<TipoIdentidadDto>();
            foreach (var doc in result)
            {
                documents.Add(
                        new TipoIdentidadDto()
                        {
                            Id = doc.Id,
                            Tipo = doc.Tipo,
                            Siglas = doc.Siglas,
                            Descripccion = doc.Descripcion
                        }
                    );
            }
            return documents;
        }

        public TipoIdentidadDto GetById(int id)
        {
            var result = _context.TipoIdentidad.FirstOrDefault(doc => doc.Id == id);


            if (result is not null)
            {
                return new TipoIdentidadDto()
                {
                    Id = result.Id,
                    Tipo = result.Tipo, 
                    Siglas = result.Siglas,
                    Descripccion = result.Descripcion != null ? result.Descripcion : "",
                    Estado = result.Estado
                };
            }
            return null;
        }

        public bool Update(TipoIdentidadDto document)
        {
            throw new NotImplementedException();
        }
    }
}