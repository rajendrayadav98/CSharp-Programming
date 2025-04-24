// Create a Hashtable that stores Employee IDs (integers) as keys and Employee Names (strings) as values.

// Add the following 5 employee entries into the Hashtable:

// 101 → "Vaibhav"

// 102 → "Danish"

// 103 → "Tushar"

// 104 → "Aniket"

// 105 → "Sumit"

// Display all the key-value pairs from the Hashtable in the format.

// Output:-
// ID: 101  Name: Vaibhav
// ID: 102  Name: Danish
// ID: 103  Name: Tushar
// ID: 104  Name: Aniket
// ID: 105  Name: Sumit
// ------------------------------------------------------
using System;
using System.Collections;
using RajendraConsoleApp.CSharp11;
namespace RajendraConsoleApp.Day28_Collection
{
    internal class Class8
    {
        static void Main()
        {
            Hashtable employees = new Hashtable();

            
            employees.Add(101, "Vaibhav");
            employees.Add(102, "Danish");
            employees.Add(103, "Tushar");
            employees.Add(104, "Aniket");
            employees.Add(105, "Sumit");

            
            foreach (int key in employees.Keys)
            {
                Console.WriteLine($"ID: {key}  Name: {employees[key]}");
                Console.ReadLine();
            }
        }
    }
}