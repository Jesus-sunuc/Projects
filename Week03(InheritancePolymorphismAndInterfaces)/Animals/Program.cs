// var benTheSquirrel = new  Animal(2, 1, "Ben");

// Console.WriteLine(benTheSquirrel);
// Console.WriteLine($"Ben's strength is {benTheSquirrel.Strength}");


// var timTheCat = new Cat();
// Console.WriteLine(timTheCat);
// Console.WriteLine($"Tim's strength is {timTheCat.Strength}");

// Console.WriteLine(timTheCat.GetType());
// Console.WriteLine(typeof(Cat));
// Console.WriteLine(timTheCat.GetType() == typeof(Animal));


// Casting examples
// Animal jimTheDog = new Dog(5, 10, true);

// Console.WriteLine(jimTheDog);
// Console.WriteLine(jimTheDog.Strength);

// var dogVersionOfJim = ((Dog)jimTheDog);

// if(dogVersionOfJim == null)
// {
//     Console.WriteLine("Jim is not a dog");
// }
// else
// {
//     Console.WriteLine(dogVersionOfJim.HasFloopyEars);
// }

// var jimTheDog = new Dog(1, 1.5, "Jim", true);

Animal benTheSquirrel = new Animal(2, 1, "Ben");
Animal timTheCat = new Cat();
Animal jimTheDog = new Dog(1, 1.5, "Jim", true);

Console.WriteLine(jimTheDog.ToString());
Console.WriteLine(jimTheDog == timTheCat);