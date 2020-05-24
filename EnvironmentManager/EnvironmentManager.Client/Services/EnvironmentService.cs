using EnvironmentManager.Core;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace EnvironmentManager.Client.Services
{
    public class EnvironmentService : IEnvironmentService
    {
        private readonly HttpClient _httpClient;

        public EnvironmentService(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<Environment> GetEnvironmentAsync(int id)
        {
            var response = await _httpClient.GetAsync($"api/environment/{id}");
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Environment>(responseContent);
        }

        public async Task<IEnumerable<Environment>> GetEnvironmentsAsync()
        {
            var response = await _httpClient.GetAsync("api/environment");
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<Environment>>(responseContent);
        }

    }
}
