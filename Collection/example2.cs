// Write a C# program that:

// Creates a non-generic ArrayList using the System.Collections namespace.

// Adds four integers (10, 20, 30, 40) to the ArrayList.

// Inserts the number 99 at the index position 2 in the list.

// Displays all elements of the updated ArrayList using a foreach loop.

// Ensure the output clearly shows the modified list after the insertion.

using System;
using System.Collections;
namespace RajendraConsoleApp.Day28_Collection
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add(20);
            arrayList.Add(30);
            arrayList.Add(40);
            arrayList.Insert(2, 99);
            foreach(int i in arrayList)
            {
                Console.WriteLine(i);
            }
        }
    }
}