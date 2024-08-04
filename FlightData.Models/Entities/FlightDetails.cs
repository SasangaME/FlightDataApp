using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlightData.Models.Entities;

public class FlightDetails : BaseEntity
{
    [MaxLength(6)]
    public string RegistrationNumber { get; set; } = string.Empty;
    public virtual Location Origin { get; set; } = new();
    public virtual Location Destination { get; set; } = new();
    public int NumOfPassengers { get; set; }
    [Column(TypeName = "decimal(18,2)")]
    public decimal Cost { get; set; }
    [MaxLength(200)]
    public string? Note { get; set; }
}
