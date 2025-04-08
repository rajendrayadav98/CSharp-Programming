// Create an interface named "IJob" that contains the following method declarations:

// void Work()

// void GetSalary()

// Create class "Doctor" implement "Ijob" interface :-
// Implement the Work() method to display: "Doctor is treating patients."

// Implement the GetSalary() method to display: "Doctor receives 30,000 per month."

// Create class "Engineer" implement "Ijob" interface :-

// Implement the Work() method to display: "Engineer is developing software."

// Implement the GetSalary() method to display: "Engineer receives 28,000 per month.

// Create a Test Class:
// In the Main() method, create objects of both Doctor and Engineer 
// Call both methods (Work() and GetSalary()) for each object.

// Output:-
// Doctor:
// Doctor is treating patients.
// Doctor receives 30,000 per month.

// Engineer:
// Engineer is developing software.
// Engineer receives 28,000 per month.

using System;

namespace RajendraConsoleApp.Day_21
{
    public interface Ijob
    {
        void Work();
        void GetSalary();
    }
    public class Doctor : Ijob
    {
        public void Work()
        {
            Console.WriteLine("Doctor is treating patients.");
        }
        public void GetSalary()
        {
            Console.WriteLine("Doctor receives 30,000 per month.");
        }
    }
        public class Engineer : Ijob
        {
            public void Work()
            {
                Console.WriteLine("Engineer is developing software.");
            }
            public void GetSalary()
            {
                Console.WriteLine("Engineer receives 28,000 per month.");
            }
        }
    internal class Class1
    {
        static void Main(string[] args)
        {
            Doctor doctor = new Doctor();
            doctor.Work();
            doctor.GetSalary();
            Engineer engineer = new Engineer();
            engineer.Work();
            engineer.GetSalary();
            Console.ReadLine(); 
        }
    }
}