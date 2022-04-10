namespace MarsRover.Business;

public static class Extensions
{
    private static readonly Dictionary<char, Direction> _directions =
        Enum.GetValues(typeof(Direction))
        .Cast<Direction>()
        .ToDictionary(k => k.ToString()[0], v => v);

    private static readonly Dictionary<char, Move> _moves =
        Enum.GetValues(typeof(Move))
        .Cast<Move>()
        .ToDictionary(k => k.ToString()[0], v => v);
    public static Direction GetDirection(this char direction)
    {
        return _directions[direction];
    }

    public static char GetDirectionChar(this Direction direction)
    {
        return direction.ToString()[0];
    }

    public static Move GetMove(this char move)
    {
        return _moves[move];
    }
}