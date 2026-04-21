using System;
using System.Collections.Generic;

namespace entityframeworkdbfirst4data.NorthWind_DBconnect;

public partial class Employee
{
    public int EmpId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string City { get; set; } = null!;
}
