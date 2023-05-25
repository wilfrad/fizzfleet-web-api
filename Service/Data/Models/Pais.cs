using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class Pais
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Siglas { get; set; } = null!;

    public string ZonaHoraria { get; set; } = null!;

    public string Nacionalidad { get; set; } = null!;

    public virtual ICollection<Departamento> Departamento { get; } = new List<Departamento>();
}
