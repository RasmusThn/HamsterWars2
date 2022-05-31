using HamsterWars2Blazor;
using HamsterWars2Blazor.Service;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:5001/") });
builder.Services.AddScoped<IHamsterHttpService, HamsterHttpService>();
builder.Services.AddScoped<IMatchHttpService, MatchHttpService>();

await builder.Build().RunAsync();
