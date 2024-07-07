using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;

namespace FlightData.SharedModels.Entities;

[Index(nameof(RegistrationNumber), IsUnique = true)]
public class FlightData : BaseEntity
{
    public string RegistrationNumber { get; set; } = string.Empty;
    public string Destination { get; set; } = string.Empty;
    public int NumberOfPassengers { get; set; }
    public string? Note { get; set; }
}