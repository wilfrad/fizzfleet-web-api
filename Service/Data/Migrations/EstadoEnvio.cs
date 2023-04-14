using System;
using System.Collections.Generic;

namespace Service.Data.Migrations;

public partial class EstadoEnvio
{
    public int Id { get; set; }

    public string Estado { get; set; } = null!;

    public string Descripción { get; set; } = null!;

    public virtual ICollection<ReporteEnvio> ReporteEnvios { get; } = new List<ReporteEnvio>();
}
