using Becom.EDI.PersonalDataExchange.Extensions;
using Becom.EDI.PersonalDataExchange.Model.Enums;
using Becom.EDI.PersonalDataExchange.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IsyZeiterfassungDemo
{
    class Program
    {
        private static IConfiguration configuration;

        static async Task<int> Main(string[] args)
        {
            var builder = new HostBuilder()
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    config.SetBasePath(hostingContext.HostingEnvironment.ContentRootPath);
                    config.AddJsonFile("appsettings.json", true, true);
                    configuration = config.Build();
                })
                .ConfigureServices((context, services) => {
                                        
                    services.AddLogging();

                    services.AddPersonalDataExchange(configuration);

                    services.AddTransient<EdiApp>();
                }).UseConsoleLifetime();

            var host = builder.Build();
            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    var myService = services.GetRequiredService<EdiApp>();
                    await myService.Run();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Occured: {ex.Message}");
                }
            }

            return 0;
        }
    }
}
