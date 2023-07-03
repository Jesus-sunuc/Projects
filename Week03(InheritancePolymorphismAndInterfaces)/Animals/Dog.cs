// public class Dog : Animal
// {
//     public bool HasFloopyEars { get; init; }
//     public Dog(int size, double weight, string name, bool hasFloopyEars) : base(size, weight, name)
//     {
//         HasFloopyEars = hasFloopyEars;
//     }

//     public override bool Equals(object obj)
//     {
//         if(obj == null)
//         {
//             return false;
//         }

//         var objDog = (Dog)obj;
//         if(objDog == null)
//         {
//             return false;
//         }

//         return objDog.Size == Size 
//             && objDog.Weight == Weight
//             && objDog.HasFloopyEars == HasFloopyEars;
//     }

// }


public class Dog : IAnimal
{
    public bool HasFloopyEars { get; init; }
    public int Size { get; init; }
    public double Weight { get; init; }
    public string Name { get; init; }

    public double Strength => throw new NotImplementedException();
    public Dog(int size, double weight, string name, bool hasFloopyEars) 
    {
        Size = size;
        Weight = weight;
        Name = name;
        HasFloopyEars = hasFloopyEars;
    }

    public override bool Equals(object obj)
    {
        if(obj == null)
        {
            return false;
        }

        var objDog = (Dog)obj;
        if(objDog == null)
        {
            return false;
        }

        return objDog.Size == Size 
            && objDog.Weight == Weight
            && objDog.HasFloopyEars == HasFloopyEars;
    }

}