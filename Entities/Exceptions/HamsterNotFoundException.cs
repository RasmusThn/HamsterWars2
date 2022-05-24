namespace Entities.Exceptions;

public sealed class HamsterNotFoundException : NotFoundException
{
    public HamsterNotFoundException(int hamsterId) 
        : base($"The Hamster with id: {hamsterId} doesn't exist in the database.")
    {

    }
}
