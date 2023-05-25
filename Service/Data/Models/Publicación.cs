using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class Publicación
{
    public int Id { get; set; }

    public int IdProducto { get; set; }

    public bool Diponibilidad { get; set; }

    public DateTime FechaPublicación { get; set; }

    public bool Activo { get; set; }

    public string? Caracteristicas { get; set; }

    public string Precio { get; set; } = null!;

    public string Categorias { get; set; } = null!;

    public string? Descripción { get; set; }

    public DateTime? FechaModificación { get; set; }

    public int FkEncargado { get; set; }

    public virtual Encargado FkEncargadoNavigation { get; set; } = null!;

    public virtual ICollection<PublicaciónCategoria> PublicaciónCategoria { get; } = new List<PublicaciónCategoria>();

    public virtual ICollection<PublicaciónImagen> PublicaciónImagen { get; } = new List<PublicaciónImagen>();
}
