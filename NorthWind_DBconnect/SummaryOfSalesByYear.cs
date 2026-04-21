using System;
using System.Collections.Generic;

namespace entityframeworkdbfirst4data.NorthWind_DBconnect;

public partial class SummaryOfSalesByYear
{
    public DateTime? ShippedDate { get; set; }

    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
