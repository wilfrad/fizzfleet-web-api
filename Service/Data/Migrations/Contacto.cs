using System;
using System.Collections.Generic;

namespace Service.Data.Migrations;

public partial class Contacto
{
    public int Id { get; set; }

    public string Celular { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string NombreReferente { get; set; } = null!;

    public int FkProveedor { get; set; }

    public virtual Proveedor FkProveedorNavigation { get; set; } = null!;
}
