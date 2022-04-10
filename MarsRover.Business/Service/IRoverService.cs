namespace MarsRover.Business
{
    public interface IRoverService
    {
        Rover Create(string roverPositionLine);
        void Move(Plateau plateau, Rover rover, string movementLine);
        string GetPosition(Rover rover);
    }
}