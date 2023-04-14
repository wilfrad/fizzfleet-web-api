using System;
using System.Collections.Generic;

namespace Service.Data.Migrations;

public partial class PublicacionCategorium
{
    public int Id { get; set; }

    public int FkCategoriaProducto { get; set; }

    public int FkPublicación { get; set; }

    public virtual CategoriaProducto FkCategoriaProductoNavigation { get; set; } = null!;

    public virtual Publicacion FkPublicaciónNavigation { get; set; } = null!;
}
