using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class ReporteEnvio
{
    public int Id { get; set; }

    public int FkMensajero { get; set; }

    public int FkEstado { get; set; }

    public string? Observasiones { get; set; }

    public DateTime FechaEntrega { get; set; }

    public virtual EstadoEnvio FkEstadoNavigation { get; set; } = null!;

    public virtual Mensajero FkMensajeroNavigation { get; set; } = null!;
}
