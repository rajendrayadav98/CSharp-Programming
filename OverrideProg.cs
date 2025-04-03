using System;

class Animal
{
    // Virtual method: This method can be overridden in derived classes
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Dog : Animal
{
    // Override the base class method to provide a specific implementation for Dog
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks");
    }
}

class Cat : Animal
{
    // Override the base class method to provide a specific implementation for Cat
    public override void MakeSound()
    {
        Console.WriteLine("The cat meows");
    }
}

class Program
{
    static void Main()
    {
        // Creating objects of derived classes
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        // Calling the overridden methods
        myDog.MakeSound();  // Outputs: The dog barks
        myCat.MakeSound();  // Outputs: The cat meows
    }
}
