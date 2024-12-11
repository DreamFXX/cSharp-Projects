// Quick showcase of abstract models.

Animal myDog = new Dog("Vrtiška", 5);
Animal myCat = new Cat("Mia", 8);

myDog.MakeSound(); // Output: Buddy says: Woof!
myCat.MakeSound(); // Output: Whiskers says: Meow!


// Classes
internal abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    protected Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Abstract method that must be implemented by derived classes
    public abstract void MakeSound();
}

internal class Dog : Animal
{
    public Dog(string name, int age) : base(name, age)
    {

    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Woof!");
    }
}

internal class Cat : Animal
{                                    //Calling the base class contructor (base).
    public Cat(string name, int age) : base(name, age)
    {

    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Meow!");
    }
}