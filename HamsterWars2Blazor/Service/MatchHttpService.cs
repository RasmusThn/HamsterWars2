using Entities.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace HamsterWars2Blazor.Service
{
    public class MatchHttpService : IMatchHttpService
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;

        public MatchHttpService(HttpClient httpClient)
        {
            _client = httpClient;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public async Task<IEnumerable<Match>> GetAllMatches()
        {
            var matches = await _client.GetFromJsonAsync<IEnumerable<Match>>("matches");

            return matches;
        }
    }
}
