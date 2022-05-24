using Contracts;
using Entities.Models;

namespace Repository;

public class HamsterRepository : RepositoryBase<Hamster>, IHamsterRepository
{
    public HamsterRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public void CreateHamster(Hamster hamster) => Create(hamster); //TODO: Här smäller det 

    public IEnumerable<Hamster> GetAllHamsters(bool trackChanges) => 
        FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();

    public Hamster GetHamsterById(int hamsterId, bool trackChanges) =>
        FindByCondition(h => h.Id.Equals(hamsterId), trackChanges)
        .SingleOrDefault();
}
