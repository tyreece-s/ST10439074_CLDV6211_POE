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
    
}