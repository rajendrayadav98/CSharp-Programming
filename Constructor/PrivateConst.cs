using System;

class MyClass
{
    
    private MyClass()
    {
        Console.WriteLine("Private Constructor Called");
    }

    
    public static MyClass CreateInstance()
    {
        return new MyClass();
    }
}

class Program
{
    static void Main()
    {
       
        MyClass obj = MyClass.CreateInstance();
    }
}
