using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace ConsoleDI
{
    class Program
    {

        static Task Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();
            ExemplifyScoping(host.Services);
            return host.RunAsync();
        }

        private static void ExemplifyScoping(IServiceProvider services)
        {
            using IServiceScope serviceScope = services.CreateScope();
            IServiceProvider provider = serviceScope.ServiceProvider;
            WorkerService workerService = provider.GetRequiredService<WorkerService>();
            workerService.Test();

        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                    services.AddTransient<IService, Service>().AddTransient<WorkerService>());


    }
}
