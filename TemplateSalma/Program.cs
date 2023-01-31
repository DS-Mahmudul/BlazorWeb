using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TemplateSalma;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("OTk3OTE1QDMyMzAyZTM0MmUzMFpCVS9sYitubmw2ZGoxNTFkZ0pOTm42SXJHNDZRdzh3NDhmSUNBUERYRVE9");
