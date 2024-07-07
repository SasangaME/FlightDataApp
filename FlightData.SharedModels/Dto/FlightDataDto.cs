namespace FlightData.SharedModels.Dto;

public class FlightDataDto
{
    public int Id { get; set; }
    public int FlightId { get; set; }
    public string RegistrationNumber { get; set; } = string.Empty;
    public string Destination { get; set; } = string.Empty;
    public int NumberOfPassengers { get; set; }
    public string? Note { get; set; }
    public decimal FlightCost { get; set; }
}