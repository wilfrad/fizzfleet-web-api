using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class PublicacionCategoria
{
    public int Id { get; set; }

    public int FkCategoriaProducto { get; set; }

    public int FkPublicacion { get; set; }

    public virtual CategoriaProducto FkCategoriaProductoNavigation { get; set; } = null!;

    public virtual Publicacion FkPublicacionNavigation { get; set; } = null!;
}
