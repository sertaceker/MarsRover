namespace MarsRover.Business;

public class Rover : IDisposable
{
    public Position Position { get; private set; }
    public Rover(Position position)
    {
        Position = position;
    }

    internal void Move(char c)
    {
        switch (c.GetMove())
        {
            case Business.Move.Left:
                TurnLeft();
                break;
            case Business.Move.Right:
                TurnRight();
                break;
            case Business.Move.MoveForward:
                MoveForward();
                break;
        }
    }

    public override string ToString()
    {
        return $"{Position.X} {Position.Y} {Position.Direction.GetDirectionChar()}";
    }

    public void Dispose()
    {
        Position.Dispose();
        GC.SuppressFinalize(this);
    }

    private void MoveForward()
    {
        switch (Position.Direction)
        {
            case Direction.North:
                Position.Y++;
                break;
            case Direction.South:
                Position.Y--;
                break;
            case Direction.West:
                Position.X--;
                break;
            case Direction.East:
                Position.X++;
                break;
        }
    }

    private void TurnLeft()
    {
        switch (Position.Direction)
        {
            case Direction.North:
                Position.Direction = Direction.West;
                break;
            case Direction.South:
                Position.Direction = Direction.East;
                break;
            case Direction.West:
                Position.Direction = Direction.South;
                break;
            case Direction.East:
                Position.Direction = Direction.North;
                break;
        }
    }

    private void TurnRight()
    {
        switch (Position.Direction)
        {
            case Direction.North:
                Position.Direction = Direction.East;
                break;
            case Direction.South:
                Position.Direction = Direction.West;
                break;
            case Direction.West:
                Position.Direction = Direction.North;
                break;
            case Direction.East:
                Position.Direction = Direction.South;
                break;
        }
    }
}
