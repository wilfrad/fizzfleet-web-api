using System;
using System.Collections.Generic;

namespace Service.Data.Migrations;

public partial class Publicacion
{
    public int Id { get; set; }

    public bool Diponibilidad { get; set; }

    public DateTime FechaPublicación { get; set; }

    public bool Activo { get; set; }

    public decimal Precio { get; set; }

    public string? Descripción { get; set; }

    public DateTime? FechaModificación { get; set; }

    public int FkEmpleado { get; set; }

    public int? FkProducto { get; set; }

    public string Titulo { get; set; } = null!;

    public virtual Empleado FkEmpleadoNavigation { get; set; } = null!;

    public virtual Producto? FkProductoNavigation { get; set; }

    public virtual ICollection<PubliacionCaracteristica> PubliacionCaracteristicas { get; } = new List<PubliacionCaracteristica>();

    public virtual ICollection<PublicacionCategorium> PublicacionCategoria { get; } = new List<PublicacionCategorium>();

    public virtual ICollection<PublicacionImagen> PublicacionImagens { get; } = new List<PublicacionImagen>();
}
