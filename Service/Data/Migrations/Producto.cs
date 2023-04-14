using System;
using System.Collections.Generic;

namespace Service.Data.Migrations;

public partial class Producto
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripción { get; set; } = null!;

    public int FkMarca { get; set; }

    public decimal ValorUnitario { get; set; }

    public int Stock { get; set; }

    public int FkAlmacen { get; set; }

    public virtual ICollection<CategoriaProducto> CategoriaProductos { get; } = new List<CategoriaProducto>();

    public virtual Almacen FkAlmacenNavigation { get; set; } = null!;

    public virtual Marca FkMarcaNavigation { get; set; } = null!;

    public virtual ICollection<MovimientosInventario> MovimientosInventarios { get; } = new List<MovimientosInventario>();

    public virtual ICollection<Publicacion> Publicacions { get; } = new List<Publicacion>();

    public virtual ICollection<SeleccionProducto> SeleccionProductos { get; } = new List<SeleccionProducto>();
}
