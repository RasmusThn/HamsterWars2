using Entities.Models;
using Shared.DataTransferObjects;
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

        public async Task CreateMatch(MatchForCreationDto match)
        {
            var response = await _client.PostAsJsonAsync<MatchForCreationDto>("api/matches", match);
            ServiceCheckManager.ResponseCheck(response);
        }

        public async Task DeleteMatch(int id)
        {
            var response = await _client.DeleteAsync($"api/matches/{id}");
            ServiceCheckManager.ResponseCheck(response);
        }

        public async Task<List<Match>> GetAllMatches()
        {
            var matches = await _client.GetFromJsonAsync<IEnumerable<Match>>("api/matches");
            ServiceCheckManager.NullCheck(matches);

            return matches.ToList();
        }

        public async Task<List<Match>> GetAllMatchesByHamsterId(int id)
        {
            var matches = await _client.GetFromJsonAsync<List<Match>>($"/matches/hamster/{id}");
            ServiceCheckManager.NullCheck(matches);

            return matches.ToList();
        }

        public async Task<List<Match>> GetAllWinMatchesByHamsterId(int id)
        {
            //TODO:Här slåt den av

            var matches = await _client.GetFromJsonAsync<List<Match>>($"/matchwinners/{id}");
            ServiceCheckManager.NullCheck(matches);
            
            return matches.ToList();
        }

        public async Task<Match> GetMatchById(int id)
        {
            var match = await _client.GetFromJsonAsync<Match>($"api/matches/{id}");
            ServiceCheckManager.NullCheck(match);
            return match;
        }
    }
}
