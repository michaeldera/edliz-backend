using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Nest;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace Edliz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();
            
            using (var scope = host.Services.CreateScope())
            {
                //find service layer in the scope
                var services = scope.ServiceProvider;
                //get the instance of DBContext service layers
                var context = services.GetRequiredService<EdlizContext>();

                //initialise data in memory
                DataGenerator.Initialise(services);
                var client = services.GetRequiredService<IElasticClient>();
                var indexManyReport = client.IndexMany(context.Articles.ToList());
            }
            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
