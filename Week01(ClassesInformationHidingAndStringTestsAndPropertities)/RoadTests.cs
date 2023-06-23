using System;
using System.Collections.Generic;
using System.Diagnostics;

class RoadTests
{
    public static void RunAll()
    {
        TestRoadStringWithNoCars();
        TestWideRoadStringWithNoCars();
        TestRoadWithCar();
        TestRoadTick();
    }

    public static void TestRoadStringWithNoCars()
    {
        var road = new Road(1, 5, new List<Car>());
        var expectedRoadString = @"
| || |
| || |
| || |
| || |
| || |
";
        var actualRoadString = road.GetAsString();
        Debug.Assert(expectedRoadString.Replace("\r", "") == actualRoadString);
    }

    public static void TestWideRoadStringWithNoCars()
    {
        var road = new Road(2, 5, new List<Car>());
        var expectedRoadString = @"
| | || | |
| | || | |
| | || | |
| | || | |
| | || | |
";
        var actualRoadString = road.GetAsString();
        Debug.Assert(expectedRoadString.Replace("\r", "") == actualRoadString);
    }

    public static void TestRoadWithCar()
    {
        var cars = new List<Car>() { new Car(1, 2, Directions.Down)};
        var road = new Road(1, 5, cars);
        var expectedRoadString = @"
| || |
| || |
| ||0|
| || |
| || |
";
        var actualRoadString = road.GetAsString();
        Debug.Assert(expectedRoadString.Replace("\r", "") == actualRoadString);
    }

    public static void TestRoadTick()
    {
        var cars = new List<Car>() { new Car(1, 2, Directions.Down)};
        var road = new Road(1, 5, cars);
        road.TickTime();
        var expectedRoadString = @"
| || |
| || |
| || |
| ||0|
| || |
";
        var actualRoadString = road.GetAsString();
        Debug.Assert(expectedRoadString.Replace("\r", "") == actualRoadString);
    }
} 


