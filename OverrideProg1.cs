// Base class (parent class)
public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

// Derived class (child class)
public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}
class Program{
    static void Main(string[] args)
    {
        Animal obj = new Animal();
        Animal dog = new dog();
          animal.Speak();  
          dog.Speak();    
         Console.ReadLine();

    }
}