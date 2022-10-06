using Blazored.LocalStorage;
using Ecommerce.Services.UI.AuthServicees;
using Ecommerce.Web;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped
    (sp => new HttpClient { BaseAddress = new Uri(builder.Configuration.GetSection("BaseURL").Value) });
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddBlazoredLocalStorage();
await builder.Build().RunAsync();
