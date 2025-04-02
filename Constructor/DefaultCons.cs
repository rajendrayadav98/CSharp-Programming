using System;

class Student
{
    public string name;  
    public int age;      
    
    
    public Student()
    {
        name = "raj";  
        age = 26;          
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Student student1 = new Student();
        
        
        Console.WriteLine("नाम: " + student1.name);  
        Console.WriteLine("आयु: " + student1.age);   
    }
}
