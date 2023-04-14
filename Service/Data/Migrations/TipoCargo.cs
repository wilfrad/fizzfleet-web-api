using System;
using System.Collections.Generic;

namespace Service.Data.Migrations;

public partial class TipoCargo
{
    public int Id { get; set; }

    public string Cargo { get; set; } = null!;

    public string Descripción { get; set; } = null!;

    public virtual ICollection<Empleado> Empleados { get; } = new List<Empleado>();
}
