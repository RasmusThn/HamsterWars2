using Entities.Models;

namespace Contracts;

public interface IHamsterRepository
{
    IEnumerable<Hamster> GetAllHamsters(bool trackChanges);
    Hamster GetHamsterById(int hamsterId, bool trackChanges);
    void CreateHamster(Hamster hamster);
}
