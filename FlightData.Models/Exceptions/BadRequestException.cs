namespace FlightData.Models.Exceptions;

public class BadRequestException(string message) : DomainException(message)
{
    
}