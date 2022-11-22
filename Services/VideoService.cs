using DeptosES.ClienteBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace DeptosES.ClienteBlazor.Services
{
    public class VideoService : IVideoService
    {
        //inyección de dependencias de HttpClient
        private readonly HttpClient _httpClient;
        public VideoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //configurar las opciones del Serializador
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public async Task<IEnumerable<Video>> GetAll()
        {
            string resp = await _httpClient.GetStringAsync($"Video");
            return JsonSerializer.Deserialize<IEnumerable<Video>>(resp, options);
        }

        public async Task<Video> GetById(int id)
        {
            string resp = await _httpClient.GetStringAsync($"Video/{id}");
            return JsonSerializer.Deserialize<Video>(resp, options);
        }
    }
}
