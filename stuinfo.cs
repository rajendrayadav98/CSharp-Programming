using System;

class Student
{
    public int Sid { get; set; }
    public string Sname { get; set; }
    public double Marks { get; set; }

    
    public void DisplayStudentInfo()
    {
        Console.WriteLine("\nStudent Information:");
        Console.WriteLine($"Student ID: {Sid}");
        Console.WriteLine($"Student Name: {Sname}");
        Console.WriteLine($"Marks: {Marks}");
    }
}

class Program
{
    static void Main()
    {
        bool continueInput = true; 
        while (continueInput)
        {
            
            Student student = new Student();

            
            Console.Write("Enter Student ID: ");
            student.Sid = int.Parse(Console.ReadLine()); 

            Console.Write("Enter Student Name: ");
            student.Sname = Console.ReadLine(); 

            Console.Write("Enter Marks: ");
            student.Marks = double.Parse(Console.ReadLine()); 

            
            student.DisplayStudentInfo();

            
            Console.Write("\nDo you want to enter details again? (y/Y to continue, any other key to exit): ");
            string userChoice = Console.ReadLine();

            
            if (userChoice.ToLower() != "y")
            {
                continueInput = false; 
            }
        }

        Console.WriteLine("\nThank you for using the Student input program!");
    }
}
