using System.ComponentModel.DataAnnotations;

namespace FlightData.Models.Entities;

public class Location : BaseEntity
{
    [MaxLength(200)]
    public string City { get; set; } = string.Empty;
    [MaxLength(200)]
    public string Country { get; set; } = string.Empty;

    public ICollection<FlightDetails> Origins { get; set; } = new List<FlightDetails>();
    public ICollection<FlightDetails> Destinations { get; set; } = new List<FlightDetails>();
}