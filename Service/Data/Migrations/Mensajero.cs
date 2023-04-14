using System;
using System.Collections.Generic;

namespace Service.Data.Migrations;

public partial class Mensajero
{
    public int Id { get; set; }

    public int FkEmpleado { get; set; }

    public int FkVehiculo { get; set; }

    public virtual ICollection<Envio> Envios { get; } = new List<Envio>();

    public virtual Empleado FkEmpleadoNavigation { get; set; } = null!;

    public virtual Vehiculo FkVehiculoNavigation { get; set; } = null!;

    public virtual ICollection<ReporteEnvio> ReporteEnvios { get; } = new List<ReporteEnvio>();
}
