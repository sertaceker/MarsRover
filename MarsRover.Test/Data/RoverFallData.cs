using MarsRover.Business;
using System.Collections;
using System.Collections.Generic;

namespace MarsRover.Test;

public class RoverFallData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] {
            new Plateau(5,5),
            new Rover(new Position(3, 3, 'E')),
            "MMM"
        };
    }
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
