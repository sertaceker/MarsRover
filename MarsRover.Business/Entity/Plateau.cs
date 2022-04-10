namespace MarsRover.Business;

public class Plateau : IDisposable
{
    public byte SizeOfX { get; set; }
    public byte SizeOfY { get; set; }

    public Plateau(byte sizeOfX, byte sizeOfY)
    {
        SizeOfX = sizeOfX;
        SizeOfY = sizeOfY;
    }

    public void Check(byte x, byte y)
    {
        if (x < 0 || x > SizeOfX || y < 0 || y > SizeOfY)
        {
            throw new RoverFallException();
        }
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}
