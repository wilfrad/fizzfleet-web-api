using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.InfraStructure.Dto
{
    public class TipoIdentidadDto
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Siglas { get; set; }
        public string? Descripccion { get; set; }
        public bool? Estado { get; set; }
    }
}
