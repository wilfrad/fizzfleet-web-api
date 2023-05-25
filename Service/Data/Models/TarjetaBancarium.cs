using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class TarjetaBancarium
{
    public int Id { get; set; }

    public string NombreBanco { get; set; } = null!;

    public string Titular { get; set; } = null!;

    public bool Credito { get; set; }

    public virtual ICollection<MetodoPago> MetodoPagos { get; } = new List<MetodoPago>();
}
