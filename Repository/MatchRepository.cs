using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class MatchRepository : RepositoryBase<Match>, IMatchRepository
    {
        public MatchRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateMatch(Match match) => Create(match);
        public void DeleteMatch(Match match) => Delete(match);
        public async Task<IEnumerable<Match>> GetAllMatchesAsync(bool trackChanges) =>
        await FindAll(trackChanges)
            .OrderBy(c =>c.Id)
            .ToListAsync();
        public async Task<Match> GetMatchByIdAsync(int matchId, bool trackChanges) =>
       await FindByCondition(h => h.Id.Equals(matchId), trackChanges)
        .SingleOrDefaultAsync();


    }
}
