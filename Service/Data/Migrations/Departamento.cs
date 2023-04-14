using System;
using System.Collections.Generic;

namespace Service.Data.Migrations;

public partial class Departamento
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int FkPais { get; set; }

    public virtual ICollection<Ciudad> Ciudads { get; } = new List<Ciudad>();

    public virtual Pai FkPaisNavigation { get; set; } = null!;
}
