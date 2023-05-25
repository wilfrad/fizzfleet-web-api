using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class Proveedor
{
    public int Id { get; set; }

    public string NIT { get; set; } = null!;

    public string NombreTitular { get; set; } = null!;

    public string? RutDirectorio { get; set; }

    public int FkCiudad { get; set; }

    public string Direccion { get; set; } = null!;

    public virtual ICollection<Contacto> Contacto { get; } = new List<Contacto>();

    public virtual Ciudad FkCiudadNavigation { get; set; } = null!;

    public virtual ICollection<Marca> Marca { get; } = new List<Marca>();
}
