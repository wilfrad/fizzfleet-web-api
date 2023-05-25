using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class CategoriaProducto
{
    public int Id { get; set; }

    public int FkProducto { get; set; }

    public int FkCategoria { get; set; }

    public virtual Categoria FkCategoriaNavigation { get; set; } = null!;

    public virtual Producto FkProductoNavigation { get; set; } = null!;

    public virtual ICollection<PublicacionCategoria> PublicacionCategoria { get; } = new List<PublicacionCategoria>();
}
