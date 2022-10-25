using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelfishBackendMySql
{
    public class Program
    {
        public static void Main(string[] args)
        {
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


//var host = new WebHostBuilder()
//.UseKestrel()
//.UseContentRoot(Directory.GetCurrentDirectory())
//.UseUrls("http://localhost:5000", "http://odin:5000", "http://192.168.1.2:5000")
//.UseIISIntegration()
//.UseStartup<Startup>()
//.Build();
