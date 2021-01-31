using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NationalArchive.Client;
using NationalArchive.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NationalArchive
{
    public class Program
    {
        public static void Main(string[] args)
        {
     

            // create a new ServiceCollection 
            var serviceCollection = new ServiceCollection();

            ConfigureServices(serviceCollection);

            // create a new ServiceProvider
            var serviceProvider = serviceCollection.BuildServiceProvider();

            //Call the Console Orders
            Menu menu = serviceProvider.GetRequiredService<Menu>();
            Console.WriteLine("National Archives");
            Console.WriteLine("Search for a Record, if you want to exit, type '-exit'");
            Console.WriteLine("Please, input a valid Record ID:");
            bool exit = false;
            while (!exit)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    if (input.Contains("-exit", StringComparison.OrdinalIgnoreCase))
                    {
                        exit = true;
                    }
                    else if (input.Contains("-clear", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Clear();
                    }
                    else if (input.Contains("-help", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Please, input a valid Record ID:");
                    }
                    else
                    {
                        var result = menu.GetRecord(input);
                        Console.WriteLine($"{result}");
                    }
                }
                Console.WriteLine("Search for a Record, if you want to exit, type '-exit'");
                Console.WriteLine("Please, input a valid Record ID:");
           }

        }
        private static void ConfigureServices(IServiceCollection serviceCollection)
        {

            // add loggers           
            serviceCollection.AddSingleton(new LoggerFactory()
                    .AddConsole()
                    .AddDebug());

            serviceCollection.AddLogging();

            serviceCollection.AddHttpClient<TNARecordDetails>()
            .ConfigurePrimaryHttpMessageHandler(handler =>
               new HttpClientHandler()
               {
                   AutomaticDecompression = System.Net.DecompressionMethods.GZip
               });
            serviceCollection.AddScoped<ITNARecordDetails, TNARecordDetails>();
            serviceCollection.AddScoped<ITNARecordCollection, TNARecordCollection>();
            serviceCollection.AddScoped<Menu>();
       
        }
     
    }
}
