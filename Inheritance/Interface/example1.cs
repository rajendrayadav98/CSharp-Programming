//  Create an interface named "IPerson" with the following method declarations:-

// void Role()

// void GetDetails()

// Create class "Teacher" implement "IPerson" interface :-

// Implement the Role() method to display:
// "Teacher teaches subjects."

// Implement the GetDetails() method to display:
// "Teacher: Name - Mr. Naresh, Subject - Dotnet"

// Create a Test Class:-
// In the Main() method, create objects of both Teacher  
// Call both Role() and GetDetails() methods 


using System;
namespace RajendraConsoleApp.Day_21
{
public interface Iperson
{
void Role();
void GetDetails();
}
internal class Teacher : Iperson
{
public void Role()
{
Console.WriteLine("Teacher teaches subject");
}
public void GetDetails()
{
Console.WriteLine("Teacher name: Bangar Raju,Subject:DotNet");
}
internal class Test
{
public static void Main(string[] args)
{
Teacher t = new Teacher();
t.Role();
t.GetDetails();
Console.ReadLine();
}
}
}
}