using System;
using System.Collections.Generic;

namespace Service.Data.Migrations;

public partial class Proveedor
{
    public int Id { get; set; }

    public string Nit { get; set; } = null!;

    public string NombreTitular { get; set; } = null!;

    public string? RutDirectorio { get; set; }

    public int FkCiudad { get; set; }

    public string Dirección { get; set; } = null!;

    public virtual ICollection<Contacto> Contactos { get; } = new List<Contacto>();

    public virtual Ciudad FkCiudadNavigation { get; set; } = null!;

    public virtual ICollection<Marca> Marcas { get; } = new List<Marca>();
}
