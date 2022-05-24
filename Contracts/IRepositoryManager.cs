namespace Contracts;

public interface IRepositoryManager
{
    IHamsterRepository Hamster { get; }
    IMatchRepository Match { get; }
    void Save();
}
