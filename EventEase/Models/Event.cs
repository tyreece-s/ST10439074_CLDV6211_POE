using System.ComponentModel.DataAnnotations;

namespace EventEase.Models;

public class Event
{
    //Primary key for Event entity
    [Key]
    public int EventId { get; set; }
    
    //Attributes
    public string EventName { get; set; }
    public DateTime EventDate { get; set; }
    public string Description { get; set; }
    
    // Nullable Navigation Property (EF will use this to link any related bookings for this event)
    public List<Booking>? Bookings { get; set; }
}