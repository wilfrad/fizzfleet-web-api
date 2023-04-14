using System;
using System.Collections.Generic;

namespace Service.Data.Migrations;

public partial class PubliacionCaracteristica
{
    public int Id { get; set; }

    public string Caracteristica { get; set; } = null!;

    public string Valor { get; set; } = null!;

    public int FkPublicación { get; set; }

    public virtual Publicacion FkPublicaciónNavigation { get; set; } = null!;
}
