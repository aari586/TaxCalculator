using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace TaxCalculatorApp;
    
public class AppConfiguration
{
    public static IHost CreateApplicationHost(string[] args)
    {
        return Host.CreateDefaultBuilder(args).ConfigureServices((context, services) =>
        {
            // Services
            
        }).ConfigureLogging(logging =>
        {
            logging.ClearProviders();
            logging.AddConsole();
        }).Build();
    } 
}
