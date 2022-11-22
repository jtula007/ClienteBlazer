using DeptosES.ClienteBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace DeptosES.ClienteBlazor.Services
{
    public class AudioService : IAudioService
    {
        //inyección de dependencias de HttpClient
        private readonly HttpClient _httpClient;
        public AudioService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //configurar las opciones del Serializador
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public async Task<IEnumerable<Audio>> GetAll()
        {
            string resp = await _httpClient.GetStringAsync($"Audio");
            return JsonSerializer.Deserialize<IEnumerable<Audio>>(resp, options);
        }

        public async Task<Audio> GetById(int id)
        {
            string resp = await _httpClient.GetStringAsync($"Audio/{id}");
            return JsonSerializer.Deserialize<Audio>(resp, options);
        }
    }
}
