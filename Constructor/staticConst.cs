using System;

class MyClass
{
    // Static field
    static int staticVariable;

    // Static constructor
    static MyClass()
    {
        Console.WriteLine("Static Constructor called");
        staticVariable = 10;  // Initialize the static variable
    }

    // Instance constructor
    public MyClass()
    {
        Console.WriteLine("Instance Constructor called");
    }

    // Static method
    public static void DisplayStaticVariable()
    {
        Console.WriteLine("Static Variable value: " + staticVariable);
    }
}

class Program
{
    static void Main()
    {
        
        MyClass.DisplayStaticVariable();

    
        MyClass obj = new MyClass();
    }
}
