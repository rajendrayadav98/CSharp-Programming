using System;
using System.Xml.Linq;

namespace RajendraConsoleApp.Day19
{
    internal class Employee
    {
        int id;
        string name;
        double salary;
        public Employee()
        {
            id = 2001;
            name = "Vaibhav";
            salary = 20000;
        }
        public void Display()
        {
            Console.WriteLine($"id: {id}\n name: {name}\n salary: {salary}");
            
        }
        class Task1
        {
            static void Main(string[] args)
            {
                Employee emp = new Employee();
                emp.Display();
                Console.ReadLine();
            }
        }
    }
}
