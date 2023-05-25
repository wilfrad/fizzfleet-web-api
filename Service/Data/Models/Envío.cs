using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class Envío
{
    public int Id { get; set; }

    public int FkPedido { get; set; }

    public int FkMensajero { get; set; }

    public TimeSpan HoraSalida { get; set; }

    public bool Activo { get; set; }

    public virtual Mensajero FkMensajeroNavigation { get; set; } = null!;

    public virtual PedidoRevisión FkPedidoNavigation { get; set; } = null!;
}
