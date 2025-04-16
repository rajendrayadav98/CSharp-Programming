// Create a "Student" class which contains the following members:-
// Instance Variables:-
//  RollNo - int
//  Name - string
//  Sub1, Sub2, Sub3 - int
//  Total - int
//  Average - double

// Generate Parameterised Constructor and Initialize the Fields

// create 2 Methods:-
// Return Type : Void
// Name : Calc()
// Accessmodifier : public 
// In Calc Method calculate total & average

// Return Type : Void
// Name :Display()
// Accessmodifier : public 
// In Display Method show the all data

// Create a Main Class name "Task" :-
// create a object for Student Class and call the methods Calc and Display

using System;

class Student
{
    // Instance variables
    private int RollNo;
    private string Name;
    private int Sub1, Sub2, Sub3;
    private int Total;
    private double Average;

    // Parameterized constructor
    public Student(int rollNo, string name, int sub1, int sub2, int sub3)
    {
        RollNo = rollNo;
        Name = name;
        Sub1 = sub1;
        Sub2 = sub2;
        Sub3 = sub3;
    }

    // Method to calculate Total and Average
    public void Calc()
    {
        Total = Sub1 + Sub2 + Sub3;
        Average = Total / 3.0;
    }

    // Method to display all student details
    public void Display()
    {
        Console.WriteLine("Student Details:");
        Console.WriteLine("Roll No: " + RollNo);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Subject 1 Marks: " + Sub1);
        Console.WriteLine("Subject 2 Marks: " + Sub2);
        Console.WriteLine("Subject 3 Marks: " + Sub3);
        Console.WriteLine("Total: " + Total);
        Console.WriteLine("Average: " + Average);
    }
}

class Task
{
    static void Main(string[] args)
    {
        // Create Student object with sample data
        Student student1 = new Student(101, "John Doe", 85, 90, 80);

        // Call methods
        student1.Calc();
        student1.Display();
    }
}
