using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service;

internal sealed class MatchService : IMatchService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;

    public MatchService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
    }

    public async Task<MatchDto> GetMatchByIdAsync(int matchId, bool trackChanges)
    {
        Match? match = await GetMatchAndCheckIfExists(matchId, trackChanges);
        var matchDto = _mapper.Map<MatchDto>(match);
        return matchDto;
    }
    public async Task<IEnumerable<MatchDto>> GetAllMatchesAsync(bool trackChanges)
    {
        var matches = await _repository.Match.GetAllMatchesAsync(trackChanges);
        var matchesDto = _mapper.Map<IEnumerable<MatchDto>>(matches);

        return matchesDto;
    }
    public async Task<MatchDto> CreateMatchAsync(MatchForCreationDto match)
    {
        var matchEntity = _mapper.Map<Match>(match);
        _repository.Match.CreateMatch(matchEntity);
        await _repository.SaveAsync();

        var matchToReturn = _mapper.Map<MatchDto>(matchEntity);

        return matchToReturn;
    }
    public async Task DeleteMatchByIdAsync(int matchId, bool trackChanges)
    {
        Match? match = await GetMatchAndCheckIfExists(matchId, trackChanges);
        _repository.Match.DeleteMatch(match);
        await _repository.SaveAsync();
    }
    public async Task<IEnumerable<MatchDto>> GetAllWinMatchesByHamsterIdAsync(int hamsterId, bool trackChanges)
    {
        var matches = await _repository.Match.GetAllMatchesAsync(trackChanges);

        var hamsterMatches = matches.Where(x=>x.WinnerId.Equals(hamsterId)).ToList();
        
        var matchesToReturn = _mapper.Map<IEnumerable<MatchDto>>(hamsterMatches);

        return matchesToReturn;
    }
    public async Task<IEnumerable<MatchDto>> GetAllMatchesByHamsterIdAsync(int hamsterId, bool trackChanges)
    {
        var matches = await _repository.Match.GetAllMatchesAsync(trackChanges);

        var hamsterMatches = matches.Where(x => x.WinnerId == hamsterId || x.LoserId == hamsterId).ToList();

        var matchesToReturn = _mapper.Map<IEnumerable<MatchDto>>(hamsterMatches);

        return matchesToReturn;
    }

    private async Task<Match> GetMatchAndCheckIfExists(int matchId, bool trackChanges)
    {
        var match = await _repository.Match.GetMatchByIdAsync(matchId, trackChanges);
        if (match is null)
        {
            throw new MatchNotFoundException(matchId);
        }

        return match;
    }
}
