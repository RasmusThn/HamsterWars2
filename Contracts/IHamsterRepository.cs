using Entities.Models;

namespace Contracts;

public interface IHamsterRepository
{
    Task<IEnumerable<Hamster>> GetAllHamstersAsync(bool trackChanges);
    Task<Hamster> GetHamsterByIdAsync(int hamsterId, bool trackChanges);
    void CreateHamster(Hamster hamster);
    void DeleteHamster(Hamster hamster);
}
