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

    public void DeleteHamsterById(int hamsterId, bool trackChanges)
    {
        var hamster = _repository.Hamster.GetHamsterById(hamsterId, trackChanges);
        if (hamster is null)
        {
            throw new HamsterNotFoundException(hamsterId);
        }
        _repository.Hamster.DeleteHamster(hamster);
        _repository.Save();
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

    public IEnumerable<HamsterDto> GetLosers(bool trackChanges)
    {
        var hamsters = _repository.Hamster.GetAllHamsters(trackChanges).ToList();

        var winners = hamsters.OrderByDescending(x => x.Losses).Take(5); //TODO: lägg till "Where(x=> x.isActive)" sen, och kanske om det bara är 3 matcher visa bara 3..

        var hamsterDto = _mapper.Map<IEnumerable<HamsterDto>>(winners);

        return hamsterDto;
    }

    public HamsterDto GetRandomHamster(bool trackChanges)
    {
        var hamsters = _repository.Hamster.GetAllHamsters(trackChanges);
        
        Random rnd = new Random();
        int n = rnd.Next(1, hamsters.Count());

        var rndHamster = hamsters.Where(h => h.Id.Equals(n)).FirstOrDefault(); //5-7 ms
        //var hamster = _repository.Hamster.GetHamsterById(n, trackChanges); //Anrop till Databas igen, 6-8ms

        var hamsterDto = _mapper.Map<HamsterDto>(rndHamster);

        return hamsterDto;
    }

    public IEnumerable<HamsterDto> GetWinners(bool trackChanges)
    {
        var hamsters = _repository.Hamster.GetAllHamsters(trackChanges).ToList();

        var winners = hamsters.OrderByDescending(x=>x.Wins).Take(5); //TODO: lägg till "Where(x=> x.isActive)" sen, och kanske om det bara är 3 matcher visa bara 3..

        var hamsterDto = _mapper.Map<IEnumerable<HamsterDto>>(winners);

        return hamsterDto;
    }

    public void UpdateHamsterGames(int hamsterId, HamsterForUpdateDto hamsterForUpdateDto, bool trackChanges)
    {
        var hamster = _repository.Hamster.GetHamsterById(hamsterId, trackChanges);

        //TODO: fortsätt här
        _mapper.Map(hamsterForUpdateDto, hamster);
        _repository.Save();
    }
}
