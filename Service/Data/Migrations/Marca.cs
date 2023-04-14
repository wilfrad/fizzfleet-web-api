using System;
using System.Collections.Generic;

namespace Service.Data.Migrations;

public partial class Marca
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int FkProveedor { get; set; }

    public virtual Proveedor FkProveedorNavigation { get; set; } = null!;

    public virtual ICollection<Producto> Productos { get; } = new List<Producto>();
}
