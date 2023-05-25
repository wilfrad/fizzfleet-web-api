using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class Producto
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int FkMarca { get; set; }

    public decimal ValorUnitario { get; set; }

    public int Stock { get; set; }

    public int FkAlmacen { get; set; }

    public virtual ICollection<CategoriaProducto> CategoriaProducto { get; } = new List<CategoriaProducto>();

    public virtual Almacen FkAlmacenNavigation { get; set; } = null!;

    public virtual Marca FkMarcaNavigation { get; set; } = null!;

    public virtual ICollection<MovimientosInventario> MovimientosInventario { get; } = new List<MovimientosInventario>();

    public virtual ICollection<Publicacion> Publicacion { get; } = new List<Publicacion>();

    public virtual ICollection<SeleccionProducto> SeleccionProducto { get; } = new List<SeleccionProducto>();
}
