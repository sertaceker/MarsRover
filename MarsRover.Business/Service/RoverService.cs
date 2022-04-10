namespace MarsRover.Business;

public class RoverService : IRoverService
{
    public Rover Create(string roverPositionLine)
    {
        using var roverPosition = GetPositionFromPositionList(GetRoverPositionList(roverPositionLine));
        using var rover = new Rover(roverPosition);
        return rover;
    }

    public void Move(Plateau plateau, Rover rover, string movementLine)
    {
        foreach (var movement in movementLine)
        {
            rover.Move(movement);
            plateau.Check(rover.Position.X, rover.Position.Y);
        }
    }
    public string GetPosition(Rover rover)
    {
        return rover.ToString();
    }

    private static string[] GetRoverPositionList(string roverPositionLine)
    {
        return roverPositionLine.Split(Constants.ROVER_SPLIT_CHAR);
    }

    private static Position GetPositionFromPositionList(string[] positionList)
    {
        return new Position(Convert.ToByte(positionList[0]), Convert.ToByte(positionList[1]), Convert.ToChar(positionList[2]));
    }
}
