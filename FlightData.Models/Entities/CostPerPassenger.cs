using System.ComponentModel.DataAnnotations.Schema;

namespace FlightData.Models.Entities;

public class CostPerPassenger : BaseEntity
{
    public int LowerBoundary { get; set; }
    public int HigherBoundary { get; set; }
    [Column(TypeName = "decimal(18,2)")]
    public decimal Cost { get; set; }
}