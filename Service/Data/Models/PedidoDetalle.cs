using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class PedidoDetalle
{
    public int Id { get; set; }

    public int FkSeleccionProducto { get; set; }

    public int Cantidad { get; set; }

    public int FkPedido { get; set; }

    public virtual Pedido FkPedidoNavigation { get; set; } = null!;

    public virtual SeleccionProducto FkSeleccionProductoNavigation { get; set; } = null!;
}
