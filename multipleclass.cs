using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajendraConsoleApp.CSharp11
{
    class Person
    {
        string name;
        int age;
        string address;

        public Person(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }
        public string DisplayInfo()
        {
            return $"Name = {name} \n Age = {age}\n Address = {address}";

        }
       
    }
    public class PersonalDetail
    {
        static void Main(string[] args)
        {
            Person obj = new Person("Rajendra",26,"Ameerpet");
            string info= obj.DisplayInfo();
            Console.WriteLine(info);
            
        }

    }
}
  

