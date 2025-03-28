using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajendraConsoleApp.CSharp11
{
    internal class Methods
    {
        public class Employee
        {
            public int id;//int.Parse
            public string name;
            public double price;
            public bool status;
        }
        public class Sample1
        {
            Employee emp=new Employee();
            public void Getdetails(int id)
            {
                
                Console.WriteLine("Enter Id");
                emp.id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name");
               emp. name= Console.ReadLine();
                Console.WriteLine("Enter Price");
               emp.price = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter status");
                emp.status= true;
            }
            static void Main(string[] args)
            {
                Sample1 demo = new Sample1();
                demo.Getdetails(1);
                Console.WriteLine($"id:{demo.emp.id},Name:{demo.emp.name},Price:{demo.emp.price},satus:{demo.emp.status}");
            }
        }
    }
}
