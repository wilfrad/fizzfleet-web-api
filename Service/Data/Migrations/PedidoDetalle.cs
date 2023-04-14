using System;
using System.Collections.Generic;

namespace Service.Data.Migrations;

public partial class PedidoDetalle
{
    public int Id { get; set; }

    public int FkSelecciónProducto { get; set; }

    public int Cantidad { get; set; }

    public int FkPedido { get; set; }

    public virtual Pedido FkPedidoNavigation { get; set; } = null!;

    public virtual SeleccionProducto FkSelecciónProductoNavigation { get; set; } = null!;
}
