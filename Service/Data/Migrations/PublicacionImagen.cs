using System;
using System.Collections.Generic;

namespace Service.Data.Migrations;

public partial class PublicacionImagen
{
    public int Id { get; set; }

    public string? Miniatura { get; set; }

    public string ImagenCompleta { get; set; } = null!;

    public int FkPublicación { get; set; }

    public bool? Principal { get; set; }

    public virtual Publicacion FkPublicaciónNavigation { get; set; } = null!;
}
