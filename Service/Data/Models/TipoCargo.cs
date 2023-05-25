using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class TipoCargo
{
    public int Id { get; set; }

    public string Cargo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Empleado> Empleado { get; } = new List<Empleado>();
}
