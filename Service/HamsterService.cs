using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service;

internal sealed class HamsterService : IHamsterService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;

    public HamsterService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
    }

    public HamsterDto CreateHamster(HamsterForCreationDto hamster)
    {
        var hamsterEntity = _mapper.Map<Hamster>(hamster);
        _repository.Hamster.CreateHamster(hamsterEntity);
        _repository.Save();
        
        var hamsterToReturn = _mapper.Map<HamsterDto>(hamsterEntity);

        return hamsterToReturn;
    }

    public IEnumerable<HamsterDto> GetAllHamsters(bool trackChanges)
    {
        
            var hamsters = _repository.Hamster.GetAllHamsters(trackChanges);
            var hamstersDto = _mapper.Map<IEnumerable<HamsterDto>>(hamsters);

            return hamstersDto;
    }

    public HamsterDto GetHamsterById(int hamsterId, bool trackChanges)
    {
        var hamster = _repository.Hamster.GetHamsterById(hamsterId, trackChanges);
        if (hamster is null)
        {
            throw new HamsterNotFoundException(hamsterId);
        }
        var hamsterDto = _mapper.Map<HamsterDto>(hamster);
        return hamsterDto;
    }
}
