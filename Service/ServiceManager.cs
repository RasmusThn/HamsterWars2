using AutoMapper;
using Contracts;
using Service.Contracts;

namespace Service
{
    public sealed class ServiceManager :IServiceManager
    {
        private readonly Lazy<IHamsterService> _hamsterService;
        private readonly Lazy<IMatchService> _matchService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager loggerManager, IMapper mapper)
        {
            _hamsterService = new Lazy<IHamsterService>(() =>
            new HamsterService(repositoryManager, loggerManager, mapper));

            _matchService = new Lazy<IMatchService>(() => 
            new MatchService(repositoryManager, loggerManager, mapper));
        }
        public IHamsterService HamsterService => _hamsterService.Value;
        public IMatchService MatchService => _matchService.Value;
    }
}
