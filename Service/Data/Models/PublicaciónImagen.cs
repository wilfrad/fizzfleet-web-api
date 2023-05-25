using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class PublicaciónImagen
{
    public int Id { get; set; }

    public string? Miniatura { get; set; }

    public string ImagenCompleta { get; set; } = null!;

    public int FkPublicación { get; set; }

    public virtual Publicación FkPublicaciónNavigation { get; set; } = null!;
}
