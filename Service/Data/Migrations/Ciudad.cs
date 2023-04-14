using System;
using System.Collections.Generic;

namespace Service.Data.Migrations;

public partial class Ciudad
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string CodigoPostal { get; set; } = null!;

    public int FkDepartamento { get; set; }

    public virtual Departamento FkDepartamentoNavigation { get; set; } = null!;

    public virtual ICollection<Locacion> Locacions { get; } = new List<Locacion>();

    public virtual ICollection<Proveedor> Proveedors { get; } = new List<Proveedor>();
}
