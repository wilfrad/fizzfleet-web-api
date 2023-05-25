using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class Departamento
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int FkPais { get; set; }

    public virtual ICollection<Ciudad> Ciudad { get; } = new List<Ciudad>();

    public virtual Pais FkPaisNavigation { get; set; } = null!;
}
