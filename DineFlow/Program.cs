using DineFlow;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Material;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");



builder.Services
                .AddBlazorise(options =>
                {
                    options.Immediate = true;
                })
                .AddMaterialProviders()
                .AddBootstrapProviders();

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddBlazorBootstrap(); // Add this line


builder.Services.AddSingleton(new HttpClient
{
    BaseAddress = new Uri("https://gobedoya-001-site1.atempurl.com/")
});
await builder.Build().RunAsync();
