using System;

namespace OverrideExample
{
    
    public class Animal
    {
    
        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    
    public class Dog : Animal
    {
        
        public override void Speak()
        {
            Console.WriteLine("Dog barks");
        }
    }


    public class Cat : Animal
    {
        
        public override void Speak()
        {
            Console.WriteLine("Cat meows");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Animal animal = new Animal();
            Animal dog = new Dog(); 
            Animal cat = new Cat(); 

            
            animal.Speak();  
            dog.Speak();    
            cat.Speak();     

            Console.ReadLine();
        }
    }
}
