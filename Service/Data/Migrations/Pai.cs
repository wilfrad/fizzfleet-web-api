using System;
using System.Collections.Generic;

namespace Service.Data.Migrations;

public partial class Pai
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Siglas { get; set; } = null!;

    public string ZonaHoraria { get; set; } = null!;

    public string Nacionalidad { get; set; } = null!;

    public virtual ICollection<Departamento> Departamentos { get; } = new List<Departamento>();
}
