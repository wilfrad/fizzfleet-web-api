using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class Encargado
{
    public int Id { get; set; }

    public int FkHorario { get; set; }

    public int FkEmpleado { get; set; }

    public int FkCargo { get; set; }

    public virtual TipoCargo FkCargoNavigation { get; set; } = null!;

    public virtual Empleado FkEmpleadoNavigation { get; set; } = null!;

    public virtual Horario FkHorarioNavigation { get; set; } = null!;

    public virtual ICollection<Mensajero> Mensajero { get; } = new List<Mensajero>();

    public virtual ICollection<MovimientosInventario> MovimientosInventario { get; } = new List<MovimientosInventario>();

    public virtual ICollection<PedidoRevisión> PedidoRevisión { get; } = new List<PedidoRevisión>();

    public virtual ICollection<Publicación> Publicación { get; } = new List<Publicación>();
}
