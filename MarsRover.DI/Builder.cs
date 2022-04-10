using Microsoft.Extensions.DependencyInjection;

namespace MarsRover.DI;
public static class Builder
{
    private static IServiceCollection _services = new ServiceCollection();
    private static IServiceProvider _provider
    {
        get
        {
            return _services.BuildServiceProvider();
        }
    }

    public static void AddSingleton<TInterface, TInstance>()
        where TInterface : class
        where TInstance : class, TInterface
    {
        _services.AddSingleton<TInterface, TInstance>();
    }

    public static T GetService<T>() where T : class
    {
        var service = _provider.GetRequiredService<T>();
        return service;
    }
}
