using System;

class Person
{
    
    public string Name;
    public int Age;

    
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        Console.WriteLine("Person object created with name: " + Name + " and age: " + Age);
    }

    
    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class Program
{
    static void Main()
    {
        
        Person person1 = new Person("Alice", 30);

        
        person1.DisplayInfo();

        
        Person person2 = new Person("Bob", 25);
        person2.DisplayInfo();
    }
}
