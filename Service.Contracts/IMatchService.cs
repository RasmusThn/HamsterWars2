using Shared.DataTransferObjects;

namespace Service.Contracts;

public interface IMatchService
{
    IEnumerable<MatchDto> GetAllMatches(bool trackChanges);
    MatchDto GetMatchById(int matchId, bool trackChanges);
    MatchDto CreateMatch(MatchForCreationDto match);

    void DeleteMatchById(int matchId, bool trackChanges);
    IEnumerable<MatchDto> GetAllMatchesByHamsterId(int hamsterId, bool trackChanges);
}
