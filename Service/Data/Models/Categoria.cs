using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class Categoria
{
    public int Id { get; set; }

    public string Etiqueta { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<CategoriaProducto> CategoriaProducto { get; } = new List<CategoriaProducto>();

    public virtual ICollection<Cupon> Cupon { get; } = new List<Cupon>();
}
