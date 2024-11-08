using System;
using System.Collections.Generic;

namespace WORK.Models;

public partial class Ticket
{
    public int TicketId { get; set; }

    public int AttractionId { get; set; }

    public string TicketType { get; set; } = null!;

    public decimal Price { get; set; }

    public DateOnly? ValidityDate { get; set; }

    public virtual Attraction Attraction { get; set; } = null!;

    public virtual ICollection<Ticketbooking> Ticketbookings { get; set; } = new List<Ticketbooking>();
}
