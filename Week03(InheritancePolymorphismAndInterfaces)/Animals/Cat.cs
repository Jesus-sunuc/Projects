// public class Cat : Animal
// {
//     public Cat() : base(1, 1.5, "Tim")
//     {

//     }
// }

public class Cat : IAnimal, IDoorBell
{
    public int Size { get; init; }
    public double Weight { get; init; }
    public string Name { get; init; }

    public double Strength => 6;

    public Cat(string name)
    {
        Size = 3;
        Weight = 2;
        Name = name;
    }

    public void Ring()
    {
        Console.WriteLine("Meow");
    }
}