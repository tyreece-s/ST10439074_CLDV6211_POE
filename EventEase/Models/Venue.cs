using System.ComponentModel.DataAnnotations;

namespace EventEase.Models;

public class Venue
{
    //Primary key for Venue entity
    [Key]
    public int VenueId { get; set; }
    
    //Attributes
    public string VenueName { get; set; }
    public string Location { get; set; }
    public int Capacity { get; set; }
    public string ImageUrl { get; set; }
    
    // Nullable Navigation Property (EF will use this to link any related bookings for this venue)
    public List<Booking>? Bookings { get; set; }
}