using System;
using System.Collections.Generic;

namespace Service.Data.Migrations;

public partial class Almacen
{
    public int Id { get; set; }

    public int Capacidad { get; set; }

    public string Ubicación { get; set; } = null!;

    public int FkBodega { get; set; }

    public virtual Bodega FkBodegaNavigation { get; set; } = null!;

    public virtual ICollection<Producto> Productos { get; } = new List<Producto>();
}
