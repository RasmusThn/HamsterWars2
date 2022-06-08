using Entities.Models;
using Shared.DataTransferObjects;

namespace HamsterWars2Blazor.Service
{
    public interface IMatchHttpService
    {
        Task<List<Match>> GetAllMatches();
        Task<List<Match>> GetAllWinMatchesByHamsterId(int id);
        Task<Match> GetMatchById(int id);
        Task CreateMatch(MatchForCreationDto match);
        Task DeleteMatch(int id);
    }
}
