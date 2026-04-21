using System;
using System.Collections.Generic;

namespace entityframeworkdbfirst4data.NorthWind_DBconnect;

public partial class CustomerDemographic
{
    public string CustomerTypeId { get; set; } = null!;

    public string? CustomerDesc { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
