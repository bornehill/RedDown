using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace RedDown
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(SetupConfiguration)
                .UseStartup<Startup>()
                .Build();

        private static void SetupConfiguration(WebHostBuilderContext ctx, IConfigurationBuilder builder)
        {
            //Removing the default configuration options
            builder.Sources.Clear();
            var _env = System.Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            //Origin from config files
            builder.AddJsonFile("config.json", optional: true, reloadOnChange: true);
            if (_env.Equals("Production"))
                builder.AddJsonFile($"config.Production.json", optional: true);
            else
                builder.AddJsonFile($"config.Development.json", optional: true);
            builder.AddXmlFile("config.xml", true)
            .AddEnvironmentVariables();
        }
    }
}
