using Core.Interfaces;
using Hardware;
using Infrastructure;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddSingleton(typeof(ILoggerAdapter<>), typeof(LoggerAdapter<>));
        services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();
