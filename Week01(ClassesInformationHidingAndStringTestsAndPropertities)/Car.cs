using System;
using System.Collections.Generic;
using System.Diagnostics;


class Car
{
    private int _x { get; set; }
    private int _y { get; set; }

    public int X 
    { 
        get => _x; 
        private set { _x = value >= 0 ? value : 0; }
    }

    public int Y 
    { 
        get => _y;
        private set { _y = value >= 0 ? value : 0; }
    }

    public Directions Direction { get; set; }

    public Car() { }

    public Car(int x, int y, Directions direction)
    {
        _x = x;
        _y = y;
        Direction = direction;
    }

    /*    public void TurnRight()
        {
            if (Direction == Directions.North)
            {
                Direction = Directions.East;
            }

            else if (Direction == Directions.East)
            {
                Direction = Directions.South;
            }

            else if (Direction == Directions.South)
            {
                Direction = Directions.West;
            }

            else if (Direction == Directions.West)
            {
                Direction = Directions.North;
            }
        }*/

    /*    public void MoveForward()
        {
            switch (Direction)
            {
                case Directions.North:
                    _y += 1;
                    break;

                case Directions.South:
                    _y -= 1;
                    break;

                case Directions.East:
                    X += 1;
                    break;

                case Directions.West:
                    X -= 1;
                    break;
            }
        }*/

    public void MoveForward()
    {
        switch (Direction)
        {
            case Directions.Up:
                Y -= 1;
                break;

            case Directions.Down:
                Y += 1;
                break;
        }
    }

    public string GetMessage()
    {
        return $"The care is at x: {X}, y: {Y}, direction: {Direction}";
    }
}