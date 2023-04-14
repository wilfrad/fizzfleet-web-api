using System;
using System.Collections.Generic;

namespace Service.Data.Migrations;

public partial class Don
{
    public int Id { get; set; }

    public bool Don1 { get; set; }

    public int FkNan { get; set; }

    public virtual Nan FkNanNavigation { get; set; } = null!;
}
