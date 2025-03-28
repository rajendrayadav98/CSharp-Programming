class Person
{
    public string Name { get; set; }
}

Person person1 = new Person();
person1.Name = "John";

Person person2 = person1; // person2 now references the same object as person1
person2.Name = "Jane";    // Changing person2 also affects person1

Console.WriteLine(person1.Name); // Outputs: Jane
Console.WriteLine(person2.Name); // Outputs: Jane
