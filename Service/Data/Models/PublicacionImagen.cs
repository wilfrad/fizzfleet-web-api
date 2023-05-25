using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class PublicacionImagen
{
    public int Id { get; set; }

    public string Miniatura { get; set; } = null!;

    public string ImagenCompleta { get; set; } = null!;

    public int FkPublicacion { get; set; }

    public bool Principal { get; set; }

    public virtual Publicacion FkPublicacionNavigation { get; set; } = null!;
}
