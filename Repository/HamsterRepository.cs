using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public class HamsterRepository : RepositoryBase<Hamster>, IHamsterRepository
{
    public HamsterRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public void CreateHamster(Hamster hamster) => Create(hamster); 
    public void DeleteHamster(Hamster hamster) => Delete(hamster);

    public async Task<IEnumerable<Hamster>> GetAllHamstersAsync(bool trackChanges) =>
        await FindAll(trackChanges)
            .OrderBy(h => h.Id)
            .ToListAsync();

    public async Task<Hamster> GetHamsterByIdAsync(int hamsterId, bool trackChanges) =>
         await FindByCondition(h => h.Id.Equals(hamsterId), trackChanges)
        .SingleOrDefaultAsync();
}
