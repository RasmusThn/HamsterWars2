
using Shared.DataTransferObjects;

namespace Service.Contracts;

public interface IHamsterService
{
    IEnumerable<HamsterDto> GetAllHamsters(bool trackChanges);
    HamsterDto GetHamsterById(int hamsterId, bool trackChanges);
    HamsterDto CreateHamster(HamsterForCreationDto hamster);
}
