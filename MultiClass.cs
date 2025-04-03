using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajendraConsoleApp.CSharp11
{
  public  class Employee
    {
        public int EmployeeId;
        public string FirstName;
        public string LastName;
        public virtual void getdetails()
        {
            EmployeeId = 101;
            FirstName = "smith";
            LastName = "adams"; 
        }
        public virtual void Display()
        {
            Console.WriteLine("id is " + EmployeeId + " firstname is " + FirstName + " lastname is " + LastName);
        }
    }
    public class fulltimeemployee:Employee
    {
        public double salary;
        public override void getdetails()
        {
            // base.getdetails();
            salary = 120000;
        }
        public override void Display()
        {
            //base.Display();
            Console.WriteLine("salary is " + salary);
        }
    }
    internal class Test
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            obj.getdetails();
            obj.Display();
            fulltimeemployee obj1 = new fulltimeemployee();
            obj1.getdetails();
            obj1.Display();
        }
    }
}
