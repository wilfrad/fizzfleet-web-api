using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class MetodoPago
{
    public int Id { get; set; }

    public string IdTransaccion { get; set; } = null!;

    public int? FkTarjeta { get; set; }

    public TimeSpan HoraPago { get; set; }

    public virtual TarjetaBancaria? FkTarjetaNavigation { get; set; }

    public virtual ICollection<Pedido> Pedido { get; } = new List<Pedido>();
}
