using Entities.Models;

namespace HamsterWars2Blazor.Service
{
    public interface IMatchHttpService
    {
        Task<List<Match>> GetAllMatches();
        Task<List<Match>> GetAllWinMatchesByHamsterId(int id);
    }
}
