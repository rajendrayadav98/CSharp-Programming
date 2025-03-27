using System;
using RajendraConsoleApp.CSharp11;

namespace RajendraConsoleApp.CSharp11
{
   
    internal class MethodOverload
    {
        public void Show(int i)
        {
            Console.WriteLine("Integer: " + i);
        }
        public void Show(string s,int i)
        {
            Console.WriteLine("String: " + s + "Integer: " + i);
        }
        public void Show(int i,string s)
        {
            Console.WriteLine("Integer: "+i + "String: "+s);
        }
    }
}
class Maen
{
    static void Main(string[] args)
    {
        MethodOverload obj = new MethodOverload();
        obj.Show(10);
        obj.Show("Hello", 20);
        obj.Show(30, "Raj");
    }
}