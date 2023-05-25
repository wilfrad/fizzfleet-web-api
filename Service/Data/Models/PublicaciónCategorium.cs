using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class PublicaciónCategorium
{
    public int Id { get; set; }

    public int FkPublicación { get; set; }

    public string Categoria { get; set; } = null!;

    public virtual Publicación FkPublicaciónNavigation { get; set; } = null!;
}
