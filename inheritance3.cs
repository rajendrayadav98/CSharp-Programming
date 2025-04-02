using System;


class Person
{
    
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }


    public Person(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }

    
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Person Details: Name: {Name}, Age: {Age}, Gender: {Gender}");
    }
}


class Employee : Person
{
    public string Position { get; set; }
    public double Salary { get; set; }

    // Constructor for the Employee class
    public Employee(string name, int age, string gender, string position, double salary)
        : base(name, age, gender)
    {
        Position = position;
        Salary = salary;
    }

    // Overriding DisplayDetails method for Employee
    public override void DisplayDetails()
    {
        Console.WriteLine($"Employee Details: Name: {Name}, Age: {Age}, Gender: {Gender}, Position: {Position}, Salary: ${Salary}");
    }
}

// Derived class - Student
class Student : Person
{
    public string School { get; set; }
    public string Grade { get; set; }

    // Constructor for the Student class
    public Student(string name, int age, string gender, string school, string grade)
        : base(name, age, gender)
    {
        School = school;
        Grade = grade;
    }

    
    public override void DisplayDetails()
    {
        Console.WriteLine($"Student Details: Name: {Name}, Age: {Age}, Gender: {Gender}, School: {School}, Grade: {Grade}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Person person1 = new Employee("John Doe", 30, "Male", "Software Engineer", 75000);
        Person person2 = new Student("Jane Smith", 20, "Female", "XYZ University", "A");

        
        person1.DisplayDetails();  
        person2.DisplayDetails();  
    }
}
