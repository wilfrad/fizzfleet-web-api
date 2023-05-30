using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class TipoRol
{
    public int Id { get; set; }

    public string Rol { get; set; } = null!;

    public string Siglas { get; set; } = null!;

    public virtual ICollection<Usuario> Usuario { get; } = new List<Usuario>();
}
