using System;
using System.Collections.Generic;

namespace Service.Data.Migrations;

public partial class Locacion
{
    public int Id { get; set; }

    public int FkCiudad { get; set; }

    public string Dirección { get; set; } = null!;

    public int FkCliente { get; set; }

    public virtual Ciudad FkCiudadNavigation { get; set; } = null!;

    public virtual Cliente FkClienteNavigation { get; set; } = null!;
}
