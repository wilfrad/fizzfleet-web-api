using System;
using System.Collections.Generic;

namespace Service.Data.Models;

public partial class Don
{
    public int Id { get; set; }

    public bool DON1 { get; set; }

    public int FkNan { get; set; }

    public virtual Nan FkNanNavigation { get; set; } = null!;
}
