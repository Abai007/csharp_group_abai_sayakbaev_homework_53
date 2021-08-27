using homework_53.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework_51
{
    public class Program
    {
        public static List<Currency> Currencies;
        public static void Main(string[] args)
        {
            string path = "wwwroot/Currencies.json";
            string data = System.IO.File.ReadAllText(path);
            Currencies = JsonConvert.DeserializeObject<List<Currency>>(data);
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
