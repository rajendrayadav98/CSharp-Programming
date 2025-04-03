using System;

class MyClass
{
    // Default constructor
    public MyClass()
    {
        Console.WriteLine("Default Constructor Called");
    }

    
    public void ShowMessage()
    {
        Console.WriteLine("Hello from MyClass!");
    }
}

class Program
{
    static void Main()
    {
        
        MyClass obj = new MyClass();  

        
        obj.ShowMessage();
    }
}
