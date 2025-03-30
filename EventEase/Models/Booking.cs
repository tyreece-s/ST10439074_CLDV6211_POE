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
    public int VenueId { get; set; } 
    
    [ForeignKey("VenueId")]  
    public Venue? Venue { get; set; } 
    
    //Event Foreign Key
    public int EventId { get; set; }
    
    [ForeignKey("EventId")]
    public Event? Event { get; set; }
}