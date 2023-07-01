var benTheSquirrel = new  Animal(2, 1);

// Console.WriteLine(benTheSquirrel);
// Console.WriteLine($"Ben's strength is {benTheSquirrel.Strength}");


var timTheCat = new Cat();
// Console.WriteLine(timTheCat);
// Console.WriteLine($"Tim's strength is {timTheCat.Strength}");

// Console.WriteLine(timTheCat.GetType());
// Console.WriteLine(typeof(Cat));
// Console.WriteLine(timTheCat.GetType() == typeof(Animal));


// Casting examples
Animal jimTheDog = new Dog(5, 10, true);

Console.WriteLine(jimTheDog);
Console.WriteLine(jimTheDog.Strength);

var dogVersionOfJim = ((Dog)jimTheDog);

if(dogVersionOfJim == null)
{
    Console.WriteLine("Jim is not a dog");
}
else
{
    Console.WriteLine(dogVersionOfJim.HasFloopyEars);
}