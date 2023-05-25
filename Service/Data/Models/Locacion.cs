using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class Locacion
{
    public int Id { get; set; }

    public int FkCiudad { get; set; }

    public string Direccion { get; set; } = null!;

    public int FkCliente { get; set; }

    public virtual Ciudad FkCiudadNavigation { get; set; } = null!;

    public virtual Cliente FkClienteNavigation { get; set; } = null!;
}
