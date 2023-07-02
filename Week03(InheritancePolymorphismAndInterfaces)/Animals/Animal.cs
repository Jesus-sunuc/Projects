public class Animal
{
    public int Size { get; init; }
    public double Weight { get; init; }

    public string Name { get; init; }

    public Animal(int size, double weight, string name)
    {
        Size = size;
        Weight = weight;
        Name = name;
    }
    public virtual double Strength { get => Weight * Size; }

    public override string? ToString()
    {
        var type = GetType();
        return $"Type: {type}, Name: {Name}, size: {Size}, weight: {Weight}";
    }

    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}
