// Animal.cs
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

// Dog.cs
public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

// Cat.cs
public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

// Program.cs
class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal();
        animal.MakeSound(); // Output: Some generic sound

        Dog dog = new Dog();
        dog.MakeSound(); // Output: Bark

        Cat cat = new Cat();
        cat.MakeSound(); // Output: Meow
    }
}
