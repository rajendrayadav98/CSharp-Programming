using System;
using System.Runtime.InteropServices;
using System.Security.Claims;
using RajendraConsoleApp.CSharp11;
using static System.Collections.Specialized.BitVector32;

namespace RajendraConsoleApp.CSharp11
{
    internal class PublicPerson
    {
        public int id;
        public string name;
        public int phone;
        public string address;
        public PublicPerson()
        {
            id = 1;
            name = "smith";
            phone = 125463;
            address = "hyderabad";
        }
        public override string ToString()
        {
            return $"PublicPerson[Id = {id},Name = {name},Phone = {phone},Address = {address}]";
        }
    }

   }
class Student : PublicPerson
{
    public int class1;
    public char section;
    public float marks;
    public Student() 
    {
        class1 = 5;
        section = 'a';
        marks = 50;
        
    }
    public override string ToString()
    {
        return base.ToString() + $", Student [Class={class1}, Section={section}, Marks={marks}]";
    }
}
class Program
{
    static void Main(string[] args)
    {
        
        Student student = new Student();

        
        Console.WriteLine(student.ToString());
    }
}
