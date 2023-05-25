using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class Empleado
{
    public int Id { get; set; }

    public DateTime FechaContratacion { get; set; }

    public DateTime? FechaUltmaRenovacion { get; set; }

    public string NombreCompleto { get; set; } = null!;

    public string NumeroIdentidad { get; set; } = null!;

    public int FkTipoIdentidad { get; set; }

    public string Telefono { get; set; } = null!;

    public int FkCargo { get; set; }

    public int FkHorario { get; set; }

    public virtual TipoCargo FkCargoNavigation { get; set; } = null!;

    public virtual Horario FkHorarioNavigation { get; set; } = null!;

    public virtual ICollection<Mensajero> Mensajero { get; } = new List<Mensajero>();

    public virtual ICollection<MovimientosInventario> MovimientosInventario { get; } = new List<MovimientosInventario>();

    public virtual ICollection<PedidoRevision> PedidoRevision { get; } = new List<PedidoRevision>();

    public virtual ICollection<Publicacion> Publicacion { get; } = new List<Publicacion>();
}
