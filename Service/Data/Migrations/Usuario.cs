using System;
using System.Collections.Generic;

namespace Service.Data.Migrations;

public partial class Usuario
{
    public int Id { get; set; }

    public string Usuario1 { get; set; } = null!;

    public string Contraseña { get; set; } = null!;

    public int FkRol { get; set; }

    public bool Activo { get; set; }

    public virtual TipoRol FkRolNavigation { get; set; } = null!;

    public virtual ICollection<Sesion> Sesions { get; } = new List<Sesion>();
}
