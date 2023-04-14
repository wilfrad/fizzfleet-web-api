using System;
using System.Collections.Generic;

namespace Service.Data.Migrations;

public partial class MetodoPago
{
    public int Id { get; set; }

    public string IdTransacción { get; set; } = null!;

    public int? FkTarjeta { get; set; }

    public TimeSpan HoraPago { get; set; }

    public virtual TarjetaBancarium? FkTarjetaNavigation { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; } = new List<Pedido>();
}
