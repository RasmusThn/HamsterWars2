using Entities.Models;
using Shared.DataTransferObjects;

namespace HamsterWars2Blazor.Service
{
    public interface IHamsterHttpService
    {
        Task<Hamster> GetHamsterById(int id);
        Task<List<Hamster>> GetAllHamsters();
        Task CreateHamster(Hamster hamster);
        Task DeleteHamster(int id);
        Task UpdateHamster(Hamster hamster);
        Task<List<Hamster>> GetTop5Winners();
        Task<List<Hamster>> GetTop5Losers();
        Task<Hamster> GetRandomHamster();
    }
}
