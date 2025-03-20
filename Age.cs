// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public  void Age()
    { 
         Console.WriteLine("Enter the age:");
        int age=Convert.ToInt32(Console.ReadLine());
      if(age<5)
        
        {
            Console.WriteLine("Child");
        }
        else if(age<18)
        {
            Console.WriteLine("Minor");
        }
        else if(age>18)
        {
            Console.WriteLine("invalid age");
        }
        else{
            Console.WriteLine("major");
        }
        
        
    }
    static void Main(string[] args)
    {
        HelloWorld obj=new HelloWorld();
        obj.Age();
       
    }
}