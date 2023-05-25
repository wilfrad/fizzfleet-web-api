using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class Vehiculo
{
    public int Id { get; set; }

    public string Marca { get; set; } = null!;

    public string Placa { get; set; } = null!;

    public bool Disponible { get; set; }

    public bool Activo { get; set; }

    public int Capacidad { get; set; }

    public virtual ICollection<Mensajero> Mensajero { get; } = new List<Mensajero>();
}
