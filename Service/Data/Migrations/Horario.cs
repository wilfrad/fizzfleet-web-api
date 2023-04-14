﻿using System;
using System.Collections.Generic;

namespace Service.Data.Migrations;

public partial class Horario
{
    public int Id { get; set; }

    public TimeSpan HoraEntrada { get; set; }

    public TimeSpan HoraSalida { get; set; }

    public decimal Salario { get; set; }

    public virtual ICollection<Empleado> Empleados { get; } = new List<Empleado>();
}
