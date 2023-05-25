using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class PubliacionCaracteristica
{
    public int Id { get; set; }

    public string Caracteristica { get; set; } = null!;

    public string Valor { get; set; } = null!;

    public int FkPublicacion { get; set; }

    public virtual Publicacion FkPublicacionNavigation { get; set; } = null!;
}
