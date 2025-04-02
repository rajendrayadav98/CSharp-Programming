using System;


class Animal
{
    
    public string Name { get; set; }

    
    public Animal(string name)
    {
        Name = name;
    }

    
    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }
}


class Dog : Animal
{

    public Dog(string name) : base(name)
    {
    }

    
    public void Bark()
    {
        Console.WriteLine($"{Name} is barking.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Dog myDog = new Dog("Buddy");

        
        myDog.Eat();  
        myDog.Bark(); 
    }
}
