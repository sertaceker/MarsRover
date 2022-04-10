using MarsRover.DI;
using MarsRover.Business;


var input = @"5 5
1 2 N
LMLMLMLMM
3 3 E
MMRMMRMRRM";

Builder.AddSingleton<IRoverService, RoverService>();
Builder.AddSingleton<IPlateauService, PlateauService>();
var plateauService = Builder.GetService<IPlateauService>();
var roverSerivce = Builder.GetService<IRoverService>();

var splittedInput = input.Split(Environment.NewLine);
var plateauLine = splittedInput[0];

using var plateau = plateauService.Create(plateauLine);

var roverCount = (splittedInput.Length - 1) / 2;

for (int i = 1; i < roverCount + 1; i++)
{
    var roverPositionLine = splittedInput[(i * 2) - 1];
    var movementLine = splittedInput[(i * 2)];

    var rover = roverSerivce.Create(roverPositionLine);
    roverSerivce.Move(plateau, rover, movementLine);

    Console.WriteLine(roverSerivce.GetPosition(rover));
}
Console.ReadKey();