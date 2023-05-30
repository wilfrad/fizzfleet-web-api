using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class Horario
{
    public int Id { get; set; }

    public string HoraEntrada { get; set; } = null!;

    public string HoraSalida { get; set; } = null!;

    public decimal Salario { get; set; }

    public virtual ICollection<Empleado> Empleado { get; } = new List<Empleado>();
}
