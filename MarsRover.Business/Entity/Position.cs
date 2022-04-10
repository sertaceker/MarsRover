namespace MarsRover.Business;

public class Position : IDisposable
{
    public byte X { get; set; }
    public byte Y { get; set; }
    public Direction Direction { get; set; }

    public Position(byte x, byte y, char direction)
    {
        X = x;
        Y = y;
        Direction = direction.GetDirection();
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}
