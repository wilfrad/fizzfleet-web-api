using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class EstadoEnvio
{
    public int Id { get; set; }

    public string Estado { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<ReporteEnvio> ReporteEnvio { get; } = new List<ReporteEnvio>();
}
