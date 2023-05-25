using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class Mensajero
{
    public int Id { get; set; }

    public int FkEmpleado { get; set; }

    public int FkVehiculo { get; set; }

    public virtual ICollection<Envio> Envio { get; } = new List<Envio>();

    public virtual Empleado FkEmpleadoNavigation { get; set; } = null!;

    public virtual Vehiculo FkVehiculoNavigation { get; set; } = null!;

    public virtual ICollection<ReporteEnvio> ReporteEnvio { get; } = new List<ReporteEnvio>();
}
