using System;
using System.Collections.Generic;

namespace Service.Data.Migrations;

public partial class Empleado
{
    public int Id { get; set; }

    public DateTime FechaContratación { get; set; }

    public DateTime? FechaUltmaRenovación { get; set; }

    public string NombreCompleto { get; set; } = null!;

    public string NumeroIdentidad { get; set; } = null!;

    public int FkTipoIdentidad { get; set; }

    public string Telefono { get; set; } = null!;

    public int FkCargo { get; set; }

    public int FkHorario { get; set; }

    public virtual TipoCargo FkCargoNavigation { get; set; } = null!;

    public virtual Horario FkHorarioNavigation { get; set; } = null!;

    public virtual ICollection<Mensajero> Mensajeros { get; } = new List<Mensajero>();

    public virtual ICollection<MovimientosInventario> MovimientosInventarios { get; } = new List<MovimientosInventario>();

    public virtual ICollection<PedidoRevision> PedidoRevisions { get; } = new List<PedidoRevision>();

    public virtual ICollection<Publicacion> Publicacions { get; } = new List<Publicacion>();
}
