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
    
    
}