using System;
using System.Runtime.InteropServices;

namespace RajendraConsoleApp.CSharp11
{
    internal class Employees2
    {
        int Empid;
        string Name;
        string Designation;
        double Salary;
        private Employees2(int empid, string name, string designation, double salary)
        {
            Empid = empid;
            Name = name;
            Designation = designation;
            Salary = salary;
        }
        public void Display()
        {
            Console.WriteLine("Employee Id:" + Empid);
            Console.WriteLine("Employee name:" + Name);
            Console.WriteLine("Employee Designation:" + Designation);
            Console.WriteLine("Employee Salary:" + Salary);
        }

        static void Main(string[] args)
        {
            Employees2 obj = new Employees2(11,"raj","sde 2",23000);
            obj.Display();
                
        }


    }
    

}
