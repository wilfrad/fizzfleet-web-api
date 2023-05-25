using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class Bodega
{
    public int Id { get; set; }

    public string Ubicacion { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public virtual ICollection<Almacen> Almacen { get; } = new List<Almacen>();
}
