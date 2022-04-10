namespace MarsRover.Business;

public class PlateauService : IPlateauService
{
    public Plateau Create(string line)
    {
        return GetPlateauFromSizeList(GetPlateauSizeList(line));
    }

    private static string[] GetPlateauSizeList(string plateauLine)
    {
        return plateauLine.Split(Constants.PLATEAU_SPLIT_CHAR);
    }

    private static Plateau GetPlateauFromSizeList(string[] sizeList)
    {
        return new Plateau(Convert.ToByte(sizeList[0]), Convert.ToByte(sizeList[1]));
    }
}
