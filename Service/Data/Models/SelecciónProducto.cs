using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class SelecciónProducto
{
    public int Id { get; set; }

    public int FkCliente { get; set; }

    public int FkProducto { get; set; }

    public int Cantidad { get; set; }

    public DateTime FechaAñadido { get; set; }

    public virtual Cliente FkClienteNavigation { get; set; } = null!;

    public virtual Producto FkProductoNavigation { get; set; } = null!;

    public virtual ICollection<PedidoDetalle> PedidoDetalle { get; } = new List<PedidoDetalle>();
}
