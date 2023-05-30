using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Usuario1 { get; set; } = null!;

    public string Contraseña { get; set; } = null!;

    public int FkRol { get; set; }

    public bool? Activo { get; set; }

    public int? IdPropietario { get; set; }

    public virtual TipoRol FkRolNavigation { get; set; } = null!;

    public virtual ICollection<Sesion> Sesion { get; } = new List<Sesion>();
}
