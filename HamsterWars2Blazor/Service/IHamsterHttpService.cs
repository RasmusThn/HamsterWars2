using Entities.Models;

namespace HamsterWars2Blazor.Service
{
    public interface IHamsterHttpService
    {
        Task<Hamster> GetHamsterById(int id);
    }
}
