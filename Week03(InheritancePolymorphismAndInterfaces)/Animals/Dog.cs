public class Dog : Animal
{
    public bool HasFloopyEars { get; init; }
    public Dog(int size, double weight, string name, bool hasFloopyEars) : base(size, weight, name)
    {
        HasFloopyEars = hasFloopyEars;
    }

}