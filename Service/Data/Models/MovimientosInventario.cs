using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class MovimientosInventario
{
    public int Id { get; set; }

    public int FkProducto { get; set; }

    public int Cantidad { get; set; }

    public DateTime FechaEntrada { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public int FkEmpleado { get; set; }

    public int FkReclamo { get; set; }

    public string? Observaciones { get; set; }

    public virtual Empleado FkEmpleadoNavigation { get; set; } = null!;

    public virtual Producto FkProductoNavigation { get; set; } = null!;

    public virtual Reclamo FkReclamoNavigation { get; set; } = null!;
}
