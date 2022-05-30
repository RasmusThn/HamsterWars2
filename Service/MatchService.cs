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

    public MatchDto GetMatchById(int matchId, bool trackChanges)
    {
        var match = _repository.Match.GetMatchById(matchId, trackChanges);
        if (match is null)
        {
            throw new MatchNotFoundException(matchId);
        }
        var matchDto = _mapper.Map<MatchDto>(match);
        return matchDto;
    }

    public IEnumerable<MatchDto> GetAllMatches(bool trackChanges)
    {
        var matches = _repository.Match.GetAllMatches(trackChanges);
        var matchesDto = _mapper.Map<IEnumerable<MatchDto>>(matches);

        return matchesDto;
    }

    public MatchDto CreateMatch(MatchForCreationDto match)
    {
        var matchEntity = _mapper.Map<Match>(match);
        _repository.Match.CreateMatch(matchEntity);
        _repository.Save();

        var matchToReturn = _mapper.Map<MatchDto>(matchEntity);

        return matchToReturn;
    }

    public void DeleteMatchById(int matchId, bool trackChanges)
    {
        var match = _repository.Match.GetMatchById(matchId, trackChanges);
        if (match is null)
        {
            throw new MatchNotFoundException(matchId);
        }
        _repository.Match.DeleteMatch(match);
        _repository.Save();
    }

    public IEnumerable<MatchDto> GetAllMatchesByHamsterId(int hamsterId, bool trackChanges)
    {
        var matches = _repository.Match.GetAllMatches(trackChanges);

        var hamsterMatches = matches.Where(x=>x.WinnerId.Equals(hamsterId)).ToList();
        
        var matchesToReturn = _mapper.Map<IEnumerable<MatchDto>>(hamsterMatches);

        return matchesToReturn;
    }
}
