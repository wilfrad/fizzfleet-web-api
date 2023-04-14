using System;
using System.Collections.Generic;

namespace Service.Data.Migrations;

public partial class Nan
{
    public int Id { get; set; }

    public string? Nan1 { get; set; }

    public virtual ICollection<Don> Dons { get; } = new List<Don>();
}
