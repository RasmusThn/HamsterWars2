
using Shared.DataTransferObjects;

namespace Service.Contracts;

public interface IHamsterService
{
    IEnumerable<HamsterDto> GetAllHamsters(bool trackChanges);
    HamsterDto GetHamsterById(int hamsterId, bool trackChanges);
    HamsterDto CreateHamster(HamsterForCreationDto hamster);
    HamsterDto GetRandomHamster(bool trackChanges);
    void DeleteHamsterById(int hamsterId, bool trackChanges);
    void UpdateHamsterGames(int hamsterId, bool isWinner, bool trackChanges);
}
