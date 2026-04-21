using System;
using System.Collections.Generic;

namespace entityframeworkdbfirst4data.MIDLAND_DBconnect;

public partial class Order
{
    public int Orderid { get; set; }

    public string? Ordername { get; set; }

    public string? Orderlocation { get; set; }
}
