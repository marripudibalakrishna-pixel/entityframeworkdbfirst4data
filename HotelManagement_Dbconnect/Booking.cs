using System;
using System.Collections.Generic;

namespace entityframeworkdbfirst4data.HotelManagement_Dbconnect;

public partial class Booking
{
    public int? Id { get; set; }

    public string? CustomerName { get; set; }

    public string? Location { get; set; }

    public DateOnly? Date { get; set; }
}
