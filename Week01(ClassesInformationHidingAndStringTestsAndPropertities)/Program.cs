using System;
using System.Collections.Generic;
using System.Diagnostics;


class Program
{
    public static void Main()
    {
        Tests();
        var car1 = new Car();
        var car2 = new Car(1, 1, Directions.Up);
        var car3 = new Car(2, 2, Directions.Up);
        var car4 = new Car(5, 7, Directions.Up);
        var car5 = new Car(0, 4, Directions.Up);
        var cars = new List<Car>() { car1, car2, car3, car4, car5 };
        var road = new Road(3, 10, cars);

        Console.WriteLine(road.GetAsString());
        for (int i = 0; i < 10; i++)
        {

            road.TickTime();
            Thread.Sleep(500);
            Console.WriteLine("Next Tick:");
            Console.WriteLine(road.GetAsString());
        }
        /*Console.WriteLine("0");*/
    }

    public static void Tests()
    {
        TestDefaultCarState();
        /*TestTurnRigt();*/
        TestMoveForward();
        TestCarConstructor();
        RoadTests.RunAll();
        Console.WriteLine("All tests passed");
    }

    public static void TestDefaultCarState()
    {
        var car = new Car();
        Debug.Assert(car.X == 0);
        Debug.Assert(car.Y == 0);
        Debug.Assert(car.Direction == Directions.Up);
    }

    /*    public static void TestTurnRigt()
        {
            var car = new Car();
            car.TurnRight();
            Debug.Assert(car.Direction == Directions.East);
            car.TurnRight();
            Debug.Assert(car.Direction == Directions.South);
        }*/

    public static void TestMoveForward()
    {
        var car = new Car(0, 0, Directions.Down);
        car.MoveForward();
        /*   car.TurnRight();
           car.MoveForward();*/

        Debug.Assert(car.X == 0);
        Debug.Assert(car.Y == 1);
    }

    public static void TestCarConstructor()
    {
        var car = new Car(3, 4, Directions.Down);
        Debug.Assert(car.Direction == Directions.Down);
        Debug.Assert(car.X == 3);
        Debug.Assert(car.Y == 4);
    }
}