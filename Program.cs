using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Syncfusion.Blazor;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace FlightTickets
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTI5ODczQDMxMzkyZTMzMmUzMFVCTFRsOG56aTJQSG83dFBCVTFvUkpzMnUrSG9WY1BxR0QzdHV1MUwzRFU9");
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddSyncfusionBlazor();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(" https://api.qrserver.com/v1/create-qr-code/?size=150x150&data=") });
            await builder.Build().RunAsync();
        }
    }
}
