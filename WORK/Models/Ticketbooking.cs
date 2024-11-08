using System;
using System.Collections.Generic;

namespace WORK.Models;

public partial class Ticketbooking
{
    public int TicketBookingId { get; set; }

    public int CustomerId { get; set; }

    public int TicketId { get; set; }

    public DateOnly BookingDate { get; set; }

    public int Quantity { get; set; }

    public decimal? TotalPrice { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Ticket Ticket { get; set; } = null!;
}
