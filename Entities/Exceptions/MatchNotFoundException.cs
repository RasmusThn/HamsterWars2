namespace Entities.Exceptions;

public sealed class MatchNotFoundException : NotFoundException
{
    public MatchNotFoundException(int matchId)
       : base($"The Match with id: {matchId} doesn't exist in the database.")
    {

    }
}
