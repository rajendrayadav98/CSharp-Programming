// Create a class Person

// Instance Variables:
// private string Firstname
// private string Lastname
// private int age 
// generate properties for the above variables.

// Create string ToString() to Print the Person details 

// Create a class Main (Executable Logic Class) which contains main method to print Person Details and pass the values through properties.?

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajendraConsoleApp.Day_24_Properties_
{
    internal class Person
    {
        private string Firstname;
        private string Lastname;
        private int age;
        public string _Firstname
        {
            get
            {
                return Firstname;
            }
            set
            {
                Firstname = value;
            }
        }
        public string _Lastname
        {
            get
            {
                return Lastname;
            }
            set
            {
                Lastname = value;
            }
        }
        public int _Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public override string ToString()
        {
            return $" FirstName: {Firstname}\n LastName: {Lastname}\n Age: {age}";
        }
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Firstname = "Rajendra";
            p.Lastname = "Yadav";
            p.age = 25;
            Console.WriteLine(p);
            Console.ReadLine();
        }

    }
}