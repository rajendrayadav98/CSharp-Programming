// Create an Interface with name "Application" having methods:-
// void OpenApp()
// void CloseApp()
// Create another Interface with name "Data" and inherits "Application" interface having methods:-
// void Save()
// void Delete()

// Create class "FileManager" implement Data interface 


// Implement of the "OpenApp" method from Application
// print "Application opened"


// Implement of the "Save" method from Data
// print "Data saved"


// Implement of the "Delete" method from Data
// print "Data deleted"


// Implement of the "CloseApp" method from Application
// print "Application closed"


// Create another class Test write main method and create instance for FileManager call the methods in that class.

// Sol:
using System;

namespace RajendraConsoleApp.Day_21
{
public interface Application
{
void OpenApp();
void CloseApp();
}
public interface Data : Application
{
void Save();
void Delete();
}
public class FileManager
{
public void OpenApp()
{
Console.WriteLine("Application opened.");
}
public void CloseApp()
{
Console.WriteLine("Application closed.");
}
public void Save()
{
Console.WriteLine("Data saved");
}
public void Delete()
{
Console.WriteLine("Data deleted.");
}
}
internal class Class3
{
static void Main(string[] args)
{
FileManager fileManager = new FileManager();
fileManager.OpenApp();
fileManager.CloseApp();
fileManager.Save();
fileManager.Delete();
Console.ReadLine();
}
}
}