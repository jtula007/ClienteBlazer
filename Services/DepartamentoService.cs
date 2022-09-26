using DeptosES.ClienteBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace DeptosES.ClienteBlazor.Services
{
    public class DepartamentoService : IDepartamentoService
    {
        //inyección de dependencias de HttpClient
        private readonly HttpClient _httpClient;
        public DepartamentoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Departamento>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpClient.GetStringAsync($"Departamento");
            return JsonSerializer.Deserialize<IEnumerable<Departamento>>(resp, options);
        }
    }
}
