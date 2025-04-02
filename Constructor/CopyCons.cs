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

    public Student(Student otherStudent)
    {
        this.name = otherStudent.name;
        this.age = otherStudent.age;
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

        
        Student student2 = new Student(student1);

        
        Console.WriteLine("Student 1:");
        student1.Display();
        Console.WriteLine("\nStudent 2 (Copy):");
        student2.Display();
    }
}
