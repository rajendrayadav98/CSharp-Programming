using System;


class Animal
{
    
    public void Eat()
    {
        Console.WriteLine("The animal is eating");
    }

    
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}


class Dog : Animal
{
    
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks");
    }
}


class Cat : Animal
{
    
    public override void MakeSound()
    {
        Console.WriteLine("The cat meows");
    }
}

class Program
{
    static void Main()
    {
        
        Animal dog = new Dog();
        Animal cat = new Cat();

    
        dog.Eat();  
        cat.Eat();  

        
        dog.MakeSound();  
        cat.MakeSound();  
    }
}
