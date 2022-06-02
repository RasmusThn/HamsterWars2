using Shared.DataTransferObjects;

namespace Service.Contracts;

public interface IHamsterService
{
    Task<IEnumerable<HamsterDto>> GetAllHamstersAsync(bool trackChanges);
    Task<HamsterDto> CreateHamsterAsync(HamsterForCreationDto hamster);
    Task<HamsterDto> GetHamsterByIdAsync(int hamsterId, bool trackChanges);
    Task<HamsterDto> GetRandomHamsterAsync(bool trackChanges);
    Task DeleteHamsterByIdAsync(int hamsterId, bool trackChanges);
    Task UpdateHamsterGamesAsync(int hamsterId, HamsterForUpdateDto hamsterForUpdateDto, bool trackChanges);
    Task<IEnumerable<HamsterDto>> GetWinnersAsync(bool trackChanges);
    Task<IEnumerable<HamsterDto>> GetLosersAsync(bool trackChanges);
}
