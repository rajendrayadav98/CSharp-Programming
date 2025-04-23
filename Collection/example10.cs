// Write a C# program that:

// Creates a non-generic ArrayList using the System.Collections namespace.

// Adds the following string elements to the ArrayList: "Banana", "Mango", "Apple", "Orange", "Grapes".

// Checks if a specific element (e.g., "Apple") exists in the ArrayList.

// If the element is found, prints the index of the element in the list.

// If the element is not found, prints a message stating that the element is not found.

// Use the Contains() method to check existence and the IndexOf() method to get the index.

// Output:-Element 'Apple' found at index 2.

using System;
using System.Collections;
namespace RajendraConsoleApp.Day28_Collection
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Banana");
            arrayList.Add("Mango");
            arrayList.Add("Apple");
            arrayList.Add("Orange");
            arrayList.Add("Grapes");
            int count= arrayList.Count;
            Console.WriteLine("Enter element to search: ");
            string element = Console.ReadLine();
            string SearchItem = "Apple";
            if (arrayList.Contains(SearchItem))
            {
                int index = arrayList.IndexOf(SearchItem);
                Console.WriteLine($"Element '{SearchItem}' found at index {index}.");
            }
            else
            {
                Console.WriteLine($"Element '{SearchItem}' not found.");
            }
        }
    }
}