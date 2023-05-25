using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class TipoIdentidad
{
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;

    public string Siglas { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<Cliente> Cliente { get; } = new List<Cliente>();
}
