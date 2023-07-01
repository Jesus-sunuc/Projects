public class Dog : Animal
{
    public bool HasFloopyEars { get; init; }
    public Dog(int size, double weight, bool hasFloopyEars) : base(size, weight)
    {
        HasFloopyEars = hasFloopyEars;
    }
}