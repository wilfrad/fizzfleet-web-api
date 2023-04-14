using System;
using System.Collections.Generic;

namespace Service.Data.Migrations;

public partial class TipoRol
{
    public int Id { get; set; }

    public string Rol { get; set; } = null!;

    public string Siglas { get; set; } = null!;

    public int Propietario { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; } = new List<Usuario>();
}
