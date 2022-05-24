using Contracts;
using Entities.Models;
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

        public IEnumerable<Match> GetAllMatches(bool trackChanges) =>
        FindAll(trackChanges)
            .OrderBy(c => c.Id)
            .ToList();


        public Match GetMatchById(int matchId, bool trackChanges) =>
        FindByCondition(h => h.Id.Equals(matchId), trackChanges)
        .SingleOrDefault();
    }
}
