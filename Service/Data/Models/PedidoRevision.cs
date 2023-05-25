using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class PedidoRevision
{
    public int Id { get; set; }

    public string Direccion { get; set; } = null!;

    public string NombreRemitente { get; set; } = null!;

    public string NumeroIdentidad { get; set; } = null!;

    public int FkEmpleado { get; set; }

    public bool? Revisado { get; set; }

    public TimeSpan? HoraRevision { get; set; }

    public int FkPedido { get; set; }

    public virtual ICollection<Envio> Envio { get; } = new List<Envio>();

    public virtual Empleado FkEmpleadoNavigation { get; set; } = null!;

    public virtual Pedido FkPedidoNavigation { get; set; } = null!;
}
