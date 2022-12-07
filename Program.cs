using System.Net.Http;
using System;
using Blazored.LocalStorage;
using Administrador.Hamber.blazor;
using Administrador.Hamber.blazor.Auth;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace Administrador.Hamber.blazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            //builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://www.hambersv.somee.com/api/") });
            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:5003/api/") });

            builder.Services.AddScoped<UserAuth>();
            builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationProvider>();
            builder.Services.AddAuthorizationCore();

            builder.Services.AddMudServices();
            builder.Services.AddBlazoredLocalStorage();

            await builder.Build().RunAsync();
        }
    }
}