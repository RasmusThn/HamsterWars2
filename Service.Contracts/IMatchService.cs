using Shared.DataTransferObjects;

namespace Service.Contracts;

public interface IMatchService
{
    Task<IEnumerable<MatchDto>> GetAllMatchesAsync(bool trackChanges);
    Task<MatchDto> GetMatchByIdAsync(int matchId, bool trackChanges);
    Task<MatchDto> CreateMatchAsync(MatchForCreationDto match);
    Task DeleteMatchByIdAsync(int matchId, bool trackChanges);
    Task<IEnumerable<MatchDto>> GetAllMatchesByHamsterIdAsync(int hamsterId, bool trackChanges);
}
