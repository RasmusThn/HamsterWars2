using Entities.Models;

namespace HamsterWars2Blazor.Service
{
    public interface IMatchHttpService
    {
        Task<IEnumerable<Match>> GetAllMatches();
    }
}
