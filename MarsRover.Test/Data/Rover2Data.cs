using MarsRover.Business;
using System.Collections;
using System.Collections.Generic;

namespace MarsRover.Test;

public class Rover2Data : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] {
            new Plateau(5,5),
            new Rover(new Position(3, 3, 'E')),
            "MMRMMRMRRM",
            "5 1 E"
        };
    }
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
