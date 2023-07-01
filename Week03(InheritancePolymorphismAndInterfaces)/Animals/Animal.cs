public class Animal
{
    public int Size { get; init; }
    public double Weight { get; init; }

    public Animal(int size, double weight)
    {
        Size = size;
        Weight = weight;
    }
    public double Strength { get => Weight * Size; }
}
