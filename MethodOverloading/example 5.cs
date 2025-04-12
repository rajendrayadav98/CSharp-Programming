using System;

class Person
{
    string name;
    int age;

    // Default constructor
    public Person()
    {
        name = "Unknown";
        age = 0;
    }

    // Constructor with one parameter
    public Person(string personName)
    {
        name = personName;
        age = 0;
    }

    // Constructor with two parameters
    public Person(string personName, int personAge)
    {
        name = personName;
        age = personAge;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + name + ", Age: " + age);
    }

    static void Main()
    {
        Person p1 = new Person();
        Person p2 = new Person("Rajendra");
        Person p3 = new Person("Yadav", 30);

        p1.DisplayInfo();
        p2.DisplayInfo();
        p3.DisplayInfo();
    }
}
