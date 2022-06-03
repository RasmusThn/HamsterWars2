using Entities.Models;
using Shared.DataTransferObjects;
using System.Net.Http.Json;
using System.Text.Json;

namespace HamsterWars2Blazor.Service
{
    public class HamsterHttpService : IHamsterHttpService
    {
        private readonly HttpClient _client;
        public HamsterHttpService(HttpClient httpClient)
        {
            _client = httpClient;
        }

        public async Task CreateHamster(Hamster hamster)
        {
           var respsonse = await _client.PostAsJsonAsync<Hamster>("api/hamsters",hamster);
            ServiceCheckManager.ResponseCheck(respsonse);            
        }

        public async Task DeleteHamster(int id)
        {
           var response =  await _client.DeleteAsync($"api/hamsters/{id}");
            
            ServiceCheckManager.ResponseCheck(response);
          
        }
        public async Task<List<Hamster>> GetAllHamsters()
        {
            var hamsters = await _client.GetFromJsonAsync<IEnumerable<Hamster>>("api/hamsters");
            ServiceCheckManager.NullCheck(hamsters);

            return hamsters.ToList();
        }
        public async Task<Hamster> GetHamsterById(int id)
        {
            var hamster = await _client.GetFromJsonAsync<Hamster>($"api/hamsters/{id}");
            ServiceCheckManager.NullCheck(hamster);
           
            return hamster;
        }
        public async Task<Hamster> GetRandomHamster()
        {
            var rndHamster = await _client.GetFromJsonAsync<Hamster>("random");
            return rndHamster;
        }
        public async Task<List<Hamster>> GetTop5Losers()
        {
            var hamsters = await _client.GetFromJsonAsync<IEnumerable<Hamster>>("/losers");
            ServiceCheckManager.NullCheck(hamsters);

            return hamsters.ToList();
        }
        public async Task<List<Hamster>> GetTop5Winners()
        {
            var hamsters = await _client.GetFromJsonAsync<IEnumerable<Hamster>>("/winners");
            ServiceCheckManager.NullCheck(hamsters);

            return hamsters.ToList();
        }
        public async Task UpdateHamster(Hamster hamster)
        {
            var respsonse = await _client.PutAsJsonAsync<Hamster>($"api/hamsters/{hamster.Id}", hamster);
            ServiceCheckManager.ResponseCheck(respsonse);
        }

       
    }
}
