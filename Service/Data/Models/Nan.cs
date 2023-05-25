using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class Nan
{
    public int Id { get; set; }

    public string? NAN1 { get; set; }

    public virtual ICollection<Don> Don { get; } = new List<Don>();
}
