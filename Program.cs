using DeptosES.ClienteBlazor.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DeptosES.ClienteBlazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://www.deptossv.somee.com/api/") });
            builder.Services.AddScoped<IDepartamentoService, DepartamentoService>();
            builder.Services.AddScoped<IMunicipioService, MunicipioService>();
            builder.Services.AddScoped<IAudioService, AudioService>();
            builder.Services.AddScoped<IVideoService, VideoService>();

            builder.Services.AddMudServices(); //importación de los servicios de MudBlazor

            await builder.Build().RunAsync();
        }
    }
}
