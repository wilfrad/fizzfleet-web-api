using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class Pedido
{
    public int Id { get; set; }

    public int FkUsuarioCliente { get; set; }

    public decimal ValorTotalSinIva { get; set; }

    public decimal IVA { get; set; }

    public DateTime FechaPago { get; set; }

    public decimal? PrecioFinal { get; set; }

    public string? CodigoCupon { get; set; }

    public int? Descuento { get; set; }

    public int FkMetodoPago { get; set; }

    public virtual MetodoPago FkMetodoPagoNavigation { get; set; } = null!;

    public virtual ICollection<PedidoDetalle> PedidoDetalle { get; } = new List<PedidoDetalle>();

    public virtual ICollection<PedidoRevision> PedidoRevision { get; } = new List<PedidoRevision>();
}
