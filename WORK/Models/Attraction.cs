using System;
using System.Collections.Generic;

namespace WORK.Models;

public partial class Attraction
{
    public int AttractionId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? Location { get; set; }

    public string? OpeningHours { get; set; }

    public decimal? Price { get; set; }

    public int? AgeRestriction { get; set; }

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
