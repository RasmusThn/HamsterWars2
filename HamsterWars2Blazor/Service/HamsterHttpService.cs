using Entities.Models;
using System.Text.Json;

namespace HamsterWars2Blazor.Service
{
    public class HamsterHttpService : IHamsterHttpService
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;

        public HamsterHttpService(HttpClient httpClient)
        {
            _client = httpClient;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public async Task<Hamster> GetHamsterById(int id)
        {
            var response = await _client.GetAsync($"hamsters/{id}");
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            var hamster = JsonSerializer.Deserialize<Hamster>(content, _options);
            return hamster;
        }
    }
}
