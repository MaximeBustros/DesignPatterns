
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main(string[] args)
    {
        using IHost host = Host.CreateDefaultBuilder(args)
        .ConfigureServices(services =>
        {
            services.AddMyAppServices();
        })
        .Build();

        var app = host.Services.GetRequiredService<IApp>();
        app.Run();
    }
}