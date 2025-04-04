using System;

namespace RajendraConsoleApp.Day19
{
    internal class Employee1
    {
        string name, dep;
        double salary;
        public Employee1(string name,string dep,double salary)
        {
            this.name = name;
            this.dep = dep;
            this.salary = salary;
        }
        public Employee1(Employee1 otherEmployee1)
        {
            this.name = otherEmployee1.name;
            this.dep = otherEmployee1.dep;
            this.salary = otherEmployee1.salary;
        }
        public override string ToString()
        {
            return $"Name: {name}\n Department: {dep}\n Salary: {salary}";
        }
        internal class Task2
        {
            static void Main(string[] args)
            {
                Employee1 obj = new Employee1("Raj", "HR", 10000);
                Employee1 obj1 = new Employee1(obj);
                Console.WriteLine(obj1);
                Console.ReadLine();
            }
        }
    }
}
