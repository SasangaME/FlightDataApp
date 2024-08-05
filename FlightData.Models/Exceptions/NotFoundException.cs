namespace FlightData.Models.Exceptions;

public class NotFoundException(string message) : DomainException(message)
{
    
}