namespace FlightData.Models.Exceptions;

public class UnAuthorizedException(string message) : DomainException(message)
{
    
}