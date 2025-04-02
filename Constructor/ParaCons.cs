using System;

class Student
{
    public string name;
    public int age;

    
    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    
    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Student student1 = new Student("Rajendra", 26);
        student1.Display();  
    }
}
