using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace IdentityServerWithAspNetIdentity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();

            Data.Migrations.IdentityServer.SeedData.EnsureSeedData(host.Services);

            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
