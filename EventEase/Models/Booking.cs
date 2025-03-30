using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventEase.Models;

public class Booking
{
    //Primary key for Booking entity (bridging table)
    [Key]
    public int BookingId { get; set; }
    
    //Attributes
    public DateTime BookingDate { get; set; }
    
    //Venue Foreign Key
    public int VenueId { get; set; } // The column for venue fk
    
    [ForeignKey("VenueId")]  // "Tells" EF this venue nav property uses that col as its fk
    public Venue? Venue { get; set; } // Nav Property which links related Venues
    
    //Event Foreign Key
    public int EventId { get; set; } // The column for event fk
    
    [ForeignKey("EventId")] // "Tells" EF this event nav property uses that col as its fk
    public Event? Event { get; set; } // Nav Property which links related Events
}