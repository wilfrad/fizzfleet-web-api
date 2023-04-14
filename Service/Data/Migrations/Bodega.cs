using System;
using System.Collections.Generic;

namespace Service.Data.Migrations;

public partial class Bodega
{
    public int Id { get; set; }

    public string Ubicación { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public virtual ICollection<Almacen> Almacens { get; } = new List<Almacen>();
}
