using System;
using System.Collections.Generic;

namespace Service.Data.Migrations;

public partial class CategoriaProducto
{
    public int Id { get; set; }

    public int FkProducto { get; set; }

    public int FkCategoria { get; set; }

    public virtual Categorium FkCategoriaNavigation { get; set; } = null!;

    public virtual Producto FkProductoNavigation { get; set; } = null!;

    public virtual ICollection<PublicacionCategorium> PublicacionCategoria { get; } = new List<PublicacionCategorium>();
}
