using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class PedidoRevisión
{
    public int Id { get; set; }

    public string Dirección { get; set; } = null!;

    public string NombreRemitente { get; set; } = null!;

    public string NumeroIdentidad { get; set; } = null!;

    public int FkEncargado { get; set; }

    public bool? Revisado { get; set; }

    public TimeSpan? HoraRevisión { get; set; }

    public int FkPedido { get; set; }

    public virtual ICollection<Envío> Envío { get; } = new List<Envío>();

    public virtual Encargado FkEncargadoNavigation { get; set; } = null!;

    public virtual Pedido FkPedidoNavigation { get; set; } = null!;
}
