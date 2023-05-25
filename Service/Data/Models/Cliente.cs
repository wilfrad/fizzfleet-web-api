using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string Nombre1 { get; set; } = null!;

    public string? Nombre2 { get; set; }

    public string Apellido1 { get; set; } = null!;

    public string? Apellido2 { get; set; }

    public string? NumeroIdentidad { get; set; }

    public int? FkTipoIdentidad { get; set; }

    public string? Telofono { get; set; }

    public string Email { get; set; } = null!;

    public virtual TipoIdentidad? FkTipoIdentidadNavigation { get; set; }

    public virtual ICollection<Locacion> Locacion { get; } = new List<Locacion>();

    public virtual ICollection<SeleccionProducto> SeleccionProducto { get; } = new List<SeleccionProducto>();
}
