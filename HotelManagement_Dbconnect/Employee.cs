using System;
using System.Collections.Generic;

namespace entityframeworkdbfirst4data.HotelManagement_Dbconnect;

public partial class Employee
{
    [System.ComponentModel.DataAnnotations.Key]
    public int Empid { get; set; }

    public string? Empname { get; set; }

    public decimal? Empsalary { get; set; }
}
