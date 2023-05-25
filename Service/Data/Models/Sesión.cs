using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class Sesión
{
    public int Id { get; set; }

    public int FkUsuario { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime? FechaCierre { get; set; }

    public string? Acción { get; set; }

    public virtual Usuario FkUsuarioNavigation { get; set; } = null!;
}
