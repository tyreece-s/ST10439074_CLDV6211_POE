using System.ComponentModel.DataAnnotations;

namespace EventEase.Models;

public class Venue
{
    //Primary key for Venue entity
    [Key]
    public int VenueId { get; set; }
    
    //Attributes
    [Display(Name = "Venue")]
    public string VenueName { get; set; }
    
    [Display(Name = "Location")]
    public string Location { get; set; }
    
    [Display(Name = "Capacity")]
    public int Capacity { get; set; }
    
    [Display(Name = "Image Url")]
    public string ImageUrl { get; set; }
    
    // Nullable Navigation Property (EF will use this to link any related bookings for this venue)
    public List<Booking>? Bookings { get; set; }
}