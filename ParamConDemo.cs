using System;

namespace RajendraConsoleApp.Constructor
{
    internal class ParamConDemo
    {
        string name;
        int age;
        string address;
        public ParamConDemo(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }
        public string DisplayInfo()
        {
            return "Name: "+name+",Age: "+age+",Address: "+address;
           
        }
    }
    class PersonaDetails
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter name: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter address: ");
            string address = Console.ReadLine();
            ParamConDemo p = new ParamConDemo(Name, age, address);
            Console.WriteLine(p.DisplayInfo());
           
            Console.ReadLine();
        }
    }
}
