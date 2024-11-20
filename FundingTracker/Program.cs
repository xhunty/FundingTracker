using FundingTracker;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHostBuilder builder = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
    })
    .UseSystemd();
IHost host = builder.Build();
host.Run();