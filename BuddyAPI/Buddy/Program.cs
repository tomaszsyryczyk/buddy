using System;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace Buddy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureAppConfiguration((hostContext, services) =>
                    {
                        var env = Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT");

                        hostContext.HostingEnvironment.EnvironmentName = env;

                        var configuration = new ConfigurationBuilder()
                            .SetBasePath(hostContext.HostingEnvironment.ContentRootPath)
                            .AddJsonFile($"appsettings.json", optional: false, reloadOnChange: true)
                            .AddJsonFile($"appsettings.{env}.json", optional: true, reloadOnChange: true)
                            .Build();
                    });
                    webBuilder.UseStartup<Startup>();
                });
    }
}
