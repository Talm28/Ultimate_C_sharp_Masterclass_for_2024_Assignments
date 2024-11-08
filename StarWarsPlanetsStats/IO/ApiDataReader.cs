using System.Text.Json;
using StarWarsPlanetsStats.DTOs;

namespace StarWarsPlanetsStats.IO
{
    public interface IApiDataReader
    {
        Task<Root> Read();
    }

    public class ApiDataReader : IApiDataReader
    {
        private string _baseAddress;
        private string _requestUri;

        public ApiDataReader(string baseAddress, string requestUri)
        {
            _baseAddress = baseAddress;
            _requestUri = requestUri;
        }

        public async Task<Root> Read()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(_baseAddress);
            HttpResponseMessage response = await client.GetAsync(_requestUri);
            response.EnsureSuccessStatusCode();
            string jsonDataString =  await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Root>(jsonDataString);
        }
    }
}