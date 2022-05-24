namespace Service.Contracts;

public interface IServiceManager
{
    IHamsterService HamsterService { get; }
    IMatchService MatchService { get; }
}
