// public class Animal
// {
//     public int Size { get; init; }
//     public double Weight { get; init; }

//     public string Name { get; init; }

//     public Animal(int size, double weight, string name)
//     {
//         Size = size;
//         Weight = weight;
//         Name = name;
//     }
//     public virtual double Strength { get => Weight * Size; }

//     public override string? ToString()
//     {
//         var type = GetType();
//         return $"Type: {type}, Name: {Name}, size: {Size}, weight: {Weight}";
//     }

//     public override bool Equals(object obj)
//     {
//         if(obj == null)
//         {
//             return false;
//         }

//         var objAsAnimal = (Animal)obj;
//         if(objAsAnimal == null)
//         {
//             return false;
//         }

//         return objAsAnimal.Size == Size && objAsAnimal.Weight == Weight;
//     }

//     public override int GetHashCode()
//     {
//         return base.GetHashCode();
//     }
// }
/***********************************************************/
public interface IAnimal
{
    public int Size { get; }
    public double Weight { get; }
    public string Name { get; }
    public double Strength { get; }
}

public interface IDoorBell
{
    public void Ring();
    // has to figure out how to alert owner
}