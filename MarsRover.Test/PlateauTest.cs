using MarsRover.Business;
using Xunit;

namespace MarsRover.Test;

[Collection(nameof(StartupFixture))]
public class PlateauTest
{
    private readonly IPlateauService _plateauService;

    public PlateauTest()
    {
        _plateauService = DI.Builder.GetService<IPlateauService>();
    }

    [Theory]
    [InlineData("5 5")]
    public void create_plateau(string line)
    {
        var plateau = _plateauService.Create(line);
        Assert.NotNull(plateau);
    }

}
