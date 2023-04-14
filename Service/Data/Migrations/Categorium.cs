using System;
using System.Collections.Generic;

namespace Service.Data.Migrations;

public partial class Categorium
{
    public int Id { get; set; }

    public string? Etiqueta { get; set; }

    public string? Descripción { get; set; }

    public virtual ICollection<CategoriaProducto> CategoriaProductos { get; } = new List<CategoriaProducto>();

    public virtual ICollection<Cupon> Cupons { get; } = new List<Cupon>();
}
