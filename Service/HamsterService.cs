﻿using AutoMapper;
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

    public async Task<HamsterDto> CreateHamsterAsync(HamsterForCreationDto hamster)
    {
        var hamsterEntity = _mapper.Map<Hamster>(hamster);
        _repository.Hamster.CreateHamster(hamsterEntity);
        await _repository.SaveAsync();

        var hamsterToReturn = _mapper.Map<HamsterDto>(hamsterEntity);

        return hamsterToReturn;
    }

    public async Task DeleteHamsterByIdAsync(int hamsterId, bool trackChanges)
    {
        Hamster? hamster = await GetHamsterAndCheckIfExists(hamsterId, trackChanges);
        _repository.Hamster.DeleteHamster(hamster);
        await _repository.SaveAsync();
    }



    public async Task<IEnumerable<HamsterDto>> GetAllHamstersAsync(bool trackChanges)
    {
        var hamsters = await _repository.Hamster.GetAllHamstersAsync(trackChanges);
        var hamstersDto = _mapper.Map<IEnumerable<HamsterDto>>(hamsters);

        return hamstersDto;
    }

    public async Task<HamsterDto> GetHamsterByIdAsync(int hamsterId, bool trackChanges)
    {
        Hamster? hamster = await GetHamsterAndCheckIfExists(hamsterId, trackChanges);

        var hamsterDto = _mapper.Map<HamsterDto>(hamster);
        return hamsterDto;
    }

    public async Task<IEnumerable<HamsterDto>> GetLosersAsync(bool trackChanges)
    {
        var hamsters = await _repository.Hamster.GetAllHamstersAsync(trackChanges);

        var winners = hamsters.OrderByDescending(x => x.Losses).Take(5); //TODO: lägg till "Where(x=> x.isActive)" sen, och kanske om det bara är 3 matcher visa bara 3..

        var hamsterDto = _mapper.Map<IEnumerable<HamsterDto>>(winners);

        return hamsterDto;
    }

    public async Task<HamsterDto> GetRandomHamsterAsync(bool trackChanges)
    {
        var hamsters = await _repository.Hamster.GetAllHamstersAsync(trackChanges); 

        Random rnd = new Random();
        int n = rnd.Next(1, hamsters.Count());

        var rndHamster = hamsters.Where(h => h.Id.Equals(n)).FirstOrDefault();

        var hamsterDto = _mapper.Map<HamsterDto>(rndHamster);

        return hamsterDto;
    }

    public async Task<IEnumerable<HamsterDto>> GetWinnersAsync(bool trackChanges)
    {
        var hamsters = await _repository.Hamster.GetAllHamstersAsync(trackChanges); //TODO: Kanske behöver vara Tolist();

        var winners = hamsters.OrderByDescending(x => x.Wins).Take(5); //TODO: lägg till "Where(x=> x.isActive)" sen, och kanske om det bara är 3 matcher visa bara 3..

        var hamsterDto = _mapper.Map<IEnumerable<HamsterDto>>(winners);

        return hamsterDto;
    }

    public async Task UpdateHamsterGamesAsync(int hamsterId, HamsterForUpdateDto hamsterForUpdateDto, bool trackChanges)
    {
        Hamster? hamster = await GetHamsterAndCheckIfExists(hamsterId, trackChanges);


        _mapper.Map(hamsterForUpdateDto, hamster);
        await _repository.SaveAsync();
    }
    private async Task<Hamster> GetHamsterAndCheckIfExists(int hamsterId, bool trackChanges)
    {
        var hamster = await _repository.Hamster.GetHamsterByIdAsync(hamsterId, trackChanges);
        if (hamster is null)
        {
            throw new HamsterNotFoundException(hamsterId);
        }

        return hamster;
    }
}
