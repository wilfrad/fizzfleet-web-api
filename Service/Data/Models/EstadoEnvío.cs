using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class EstadoEnvío
{
    public int Id { get; set; }

    public string NombreEstado { get; set; } = null!;

    public string Descripción { get; set; } = null!;

    public virtual ICollection<ReporteEnvío> ReporteEnvío { get; } = new List<ReporteEnvío>();
}
