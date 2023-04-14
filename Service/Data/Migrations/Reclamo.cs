using System;
using System.Collections.Generic;

namespace Service.Data.Migrations;

public partial class Reclamo
{
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;

    public int IdRemitente { get; set; }

    public virtual ICollection<MovimientosInventario> MovimientosInventarios { get; } = new List<MovimientosInventario>();
}
