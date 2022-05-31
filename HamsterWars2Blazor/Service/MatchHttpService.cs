using Entities.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace HamsterWars2Blazor.Service
{
    public class MatchHttpService : IMatchHttpService
    {
        private readonly HttpClient _client;

        public MatchHttpService(HttpClient httpClient)
        {
            _client = httpClient;
        }

        public async Task<List<Match>> GetAllMatches()
        {
            var matches = await _client.GetFromJsonAsync<IEnumerable<Match>>("api/matches");
            ServiceCheckManager.NullCheck(matches);

            return matches.ToList();
        }

    }
}
