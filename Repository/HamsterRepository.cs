using Contracts;
using Entities.Models;

namespace Repository;

public class HamsterRepository : RepositoryBase<Hamster>, IHamsterRepository
{
    public HamsterRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public void CreateHamster(Hamster hamster) => Create(hamster); 
    public void DeleteHamster(Hamster hamster) => Delete(hamster);

    public async Task<IEnumerable<Hamster>> GetAllHamstersAsync(bool trackChanges) => 
        FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();

    public async Task<Hamster> GetHamsterByIdAsync(int hamsterId, bool trackChanges) =>
        FindByCondition(h => h.Id.Equals(hamsterId), trackChanges)
        .SingleOrDefault();
}
