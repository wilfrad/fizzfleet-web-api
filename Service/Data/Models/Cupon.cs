using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class Cupon
{
    public int Id { get; set; }

    public int Descuento { get; set; }

    public decimal ValorRequerido { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime? FechaCaducidad { get; set; }

    public bool Activo { get; set; }

    public int FkCategoria { get; set; }

    public string Codigo { get; set; } = null!;

    public virtual Categoria FkCategoriaNavigation { get; set; } = null!;
}
