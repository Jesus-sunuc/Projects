class Road
{
    private int LaneCount { get; }
    private int Length { get; }
    private List<Car> Cars { get; }

    public Road(int laneCount, int length, List<Car> cars)
    {
        LaneCount = laneCount;
        Length = length;
        Cars = cars;
    }

    // public string GetAsString()
    // {
    //     var roadString = "\n";
    //     for (int i = 0; i < Length; i++)
    //     {
    //         var rowString = "";
    //         var rowCharacterLength = (LaneCount * 2 + 1) + (LaneCount * 2);
    //         for (int j = 0; j < rowCharacterLength; j++)
    //         {
    //             var jIsEven = j % 2 == 0;
    //             if (jIsEven)
    //             {
    //                 rowString += "|";
    //             }
    //             else
    //             {
    //                 if (IsCar(j, i))
    //                 {
    //                     rowString += "0";
    //                 }
    //                 else
    //                 {
    //                     rowString += " ";
    //                 }
    //             }
    //         }

    //         roadString = roadString + (rowString + "\n");
    //     }

    //     return roadString;
    // }

    public string GetAsString()
    {
        var roadString = "\n";
        for (int i = 0; i < Length; i++)
        {
            roadString = GetRowText(roadString, i);
        }

        return roadString;
    }

    private string GetRowText(string roadString, int rowNumber)
    {
        var rowString = "";
        var rowCharacterLength = (LaneCount * 2 + 1) + (LaneCount * 2);
        for (int j = 0; j < rowCharacterLength; j++)
        {
            var charShouldBeLine = j % 2 == 0;
            if (charShouldBeLine)
            {
                rowString += GetNextLineChar(rowCharacterLength, j);
            }
            else
            {
                rowString += GetNextLaneChar(rowNumber, j);
            }
        }

        roadString = roadString + (rowString + "\n");
        return roadString;
    }

    private string GetNextLaneChar(int rowNumber, int j)
    {
        if(!IsCar(j, rowNumber))
            return " ";
        if(IsCollision(j, rowNumber))
            return "X";
        return "0";
    }

    private bool IsCollision(int colNumber, int rowNumber)
    {
        var carXValue = GetCarXValue(colNumber);
        var carYValue = rowNumber;
        var carsInThisSpot = new List<Car>();
        foreach (var car in Cars)
        {
            if (car.X == carXValue && car.Y == rowNumber)
            {
                carsInThisSpot.Add(car);
            }
        }

        return carsInThisSpot.Count > 1;
    }

    private static string GetNextLineChar(int rowCharacterLength, int j)
    {
        int middleIndex = rowCharacterLength / 2;
        var isMiddelLine = j == middleIndex;
        return isMiddelLine
            ? "||"
            : "|";
    }

    private bool IsCar(int colNumber, int rowNumber)
    {
        int carXValue = GetCarXValue(colNumber);
        int carYValue = rowNumber;

        foreach (var car in Cars)
        {
            if (car.X == carXValue && car.Y == carYValue)
            {
                return true;
            }
        }
        return false;
    }

    private static int GetCarXValue(int colNumber)
    {
        return colNumber / 2;
    }

    internal void TickTime()
    {
        foreach (var car in Cars)
        {
            car.MoveForward();
        }
    }
}