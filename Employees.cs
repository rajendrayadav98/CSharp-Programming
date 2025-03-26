using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using RajendraConsoleApp.CSharp11;

namespace RajendraConsoleApp.CSharp11
{
    internal class Employees
    {
        public int Empid;
        public string Name;
        public string Designation;
        public double Salary;

        public Employees(int empid,string name,string designation,double salary)
        {
            Empid = empid;
            Name = name;
            Designation = designation;
            Salary = salary;
        }
        public void Display() 
        {
            Console.WriteLine("Employee Id:"+Empid);
            Console.WriteLine("Employee name:" +Name);
            Console.WriteLine("Employee Designation:" + Designation);
            Console.WriteLine("Employee Salary:" + Salary);
        }
        
        
    }
class Emp
{
    static void Main(string[] args)
    {
        Employees cd1 = new Employees(122, "Raju", "Fraud", 9999);
        cd1.Display();
    }
}
}
