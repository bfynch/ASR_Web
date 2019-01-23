using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Asr.Areas.Identity.IdentityHostingStartup))]
namespace Asr.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => { });
        }
    }
}
