using MarsRover.Business;
using Xunit;

namespace MarsRover.Test;

[Collection(nameof(StartupFixture))]
public class RoverTest
{
    private readonly IRoverService _roverService;
    public RoverTest()
    {
        _roverService = DI.Builder.GetService<IRoverService>();
    }


    [Theory]
    [InlineData("1 2 N")]
    public void create_rover(string roverPositionLine)
    {
        var rover = _roverService.Create(roverPositionLine);
        Assert.NotNull(rover);
    }

    [Theory]
    [ClassData(typeof(Rover1Data))]
    [ClassData(typeof(Rover2Data))]
    public void success_movement(Plateau plateau, Rover rover, string movementLine, string expected)
    {
        _roverService.Move(plateau, rover, movementLine);
        var position = _roverService.GetPosition(rover);
        Assert.NotNull(position);
        Assert.Equal(expected, position);
    }

    [Theory]
    [ClassData(typeof(RoverFallData))]
    public void fall_movement(Plateau plateau, Rover rover, string movementLine)
    {
        Assert.Throws<RoverFallException>(() => _roverService.Move(plateau, rover, movementLine));
    }
}
