using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajendraConsoleApp.Day19
{
    internal class Student
    {
        int Id;
        string Name;
        int Sub1,Sub2,Sub3;
        int Total;
        double Avg;
        public Student(int Id, string Name, int Sub1, int Sub2, int Sub3)
        { 
            this.Id = Id;
            this.Name = Name;
            this.Sub1 = Sub1;
            this.Sub2 = Sub2;
            this.Sub3 = Sub3;
//this.Total = Total;
  //          this.Avg = Avg;
        }
        public void Calc()
        {
            Total = Sub1 + Sub2 + Sub3;
            Avg = Total / 3;
        }
        public void Display()
        {
            Console.WriteLine($"Id: {Id}\n Name: {Name}\n Sub1: {Sub1}\n Sub2: {Sub2}\n Sub: {Sub3}\n Total: {Total}\n Average: {Avg}");

        }
    }
    class Task
    {
        static void Main(string[] args)
        {
            Student obj = new Student(101,"Raj",50,45,40);
            obj.Calc();
            obj.Display();
            Console.ReadLine();
        }
    }
}
