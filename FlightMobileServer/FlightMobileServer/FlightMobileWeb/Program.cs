using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;


namespace FlightAppServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Client client = new Client();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
