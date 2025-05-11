using Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddMyAppServices(this IServiceCollection services)
    {
        services.AddSingleton<IApp, App>();
        services.AddSingleton<IDependencyInjectionDatabase, DependencyInjectionDatabase>();
        // Add more of your services here
        return services; // allows method chaining
    }
}
