using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class Cupón
{
    public int Id { get; set; }

    public int Descuento { get; set; }

    public decimal ValorRequerido { get; set; }

    public DateTime FechaModificación { get; set; }

    public DateTime? FechaCaducidad { get; set; }

    public bool Activo { get; set; }

    public int FkCategoriaProducto { get; set; }

    public string Codigo { get; set; } = null!;

    public virtual CategoriaProducto FkCategoriaProductoNavigation { get; set; } = null!;
}
