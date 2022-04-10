using MarsRover.Business;
using System.Threading.Tasks;
using Xunit;

namespace MarsRover.Test;

[CollectionDefinition(nameof(StartupFixture))]
public class StartupFixtureCollection : ICollectionFixture<StartupFixture> { }
public class StartupFixture : IAsyncLifetime
{
    public StartupFixture()
    {
        DI.Builder.AddSingleton<IRoverService, RoverService>();
        DI.Builder.AddSingleton<IPlateauService, PlateauService>();
    }

    public Task DisposeAsync() => Task.CompletedTask;

    public Task InitializeAsync() => Task.CompletedTask;
}
