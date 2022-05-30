using Entities.Models;

namespace Contracts;

public interface IMatchRepository
{
    IEnumerable<Match> GetAllMatches(bool trackChanges);
    Match GetMatchById(int matchId, bool trackChanges);
    void CreateMatch(Match match);
    void DeleteMatch(Match match);

}
