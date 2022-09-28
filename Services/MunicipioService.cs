using DeptosES.ClienteBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace DeptosES.ClienteBlazor.Services
{
    public class MunicipioService : IMunicipioService
    {
        //inyección de dependencias de HttpClient
        private readonly HttpClient _httpClient;
        public MunicipioService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //configurar las opciones del Serializador
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public async Task<IEnumerable<Municipio>> GetAll()
        {
            string resp = await _httpClient.GetStringAsync($"Municipio");
            return JsonSerializer.Deserialize<IEnumerable<Municipio>>(resp, options);
        }

        public async Task<IEnumerable<Municipio>> GetByDepartamento(int idDepto)
        {
            var resp = await _httpClient.PostAsJsonAsync($"Municipio/Buscar", new { idDepartamento = idDepto });
            string respString = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Municipio>>(respString, options);
        }

        public async Task<Municipio> GetById(int id)
        {
            string resp = await _httpClient.GetStringAsync($"Municipio/{id}");
            return JsonSerializer.Deserialize<Municipio>(resp, options);
        }
    }
}
