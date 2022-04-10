using MarsRover.Business;
using System.Collections;
using System.Collections.Generic;

namespace MarsRover.Test;

public class Rover1Data : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] {
            new Plateau(5,5),
            new Rover(new Position(1, 2, 'N')),
            "LMLMLMLMM",
            "1 3 N"
        };
    }
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
