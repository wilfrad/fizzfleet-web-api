using System;
using System.Collections.Generic;

namespace Service.Data.Migrations;

public partial class TipoIdentidad
{
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;

    public string Siglas { get; set; } = null!;

    public string? Descripción { get; set; }

    public virtual ICollection<Cliente> Clientes { get; } = new List<Cliente>();
}
