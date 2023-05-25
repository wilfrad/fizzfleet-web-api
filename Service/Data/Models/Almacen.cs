using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class Almacen
{
    public int Id { get; set; }

    public int Capacidad { get; set; }

    public string Ubicacion { get; set; } = null!;

    public int FkBodega { get; set; }

    public virtual Bodega FkBodegaNavigation { get; set; } = null!;

    public virtual ICollection<Producto> Producto { get; } = new List<Producto>();
}
