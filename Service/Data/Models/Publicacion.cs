using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class Publicacion
{
    public int Id { get; set; }

    public bool Diponibilidad { get; set; }

    public DateTime FechaPublicacion { get; set; }

    public bool? Activo { get; set; }

    public decimal Precio { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public int FkEmpleado { get; set; }

    public int? FkProducto { get; set; }

    public string Titulo { get; set; } = null!;

    public virtual Empleado FkEmpleadoNavigation { get; set; } = null!;

    public virtual Producto? FkProductoNavigation { get; set; }

    public virtual ICollection<PubliacionCaracteristica> PubliacionCaracteristica { get; } = new List<PubliacionCaracteristica>();

    public virtual ICollection<PublicacionCategoria> PublicacionCategoria { get; } = new List<PublicacionCategoria>();

    public virtual ICollection<PublicacionImagen> PublicacionImagen { get; } = new List<PublicacionImagen>();
}
