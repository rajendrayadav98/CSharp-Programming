// Write a C# program that:

// Creates a non-generic ArrayList using the System.Collections namespace.

// Adds the following string items to the ArrayList: "Pen", "Pencil", "Eraser", "Sharpener", "Scale".

// Displays all items in the list before removal.

// Removes the item "Eraser" from the list using the Remove() method.

// Displays all items after the removal to reflect the updated list.

// Use a foreach loop for displaying the contents of the list.

// Output:-ArrayList before removing 'Eraser':
// Pen
// Pencil
// Eraser
// Sharpener
// Scale

// ArrayList after removing 'Eraser':
// Pen
// Pencil
// Sharpener
// Scale

using System;
using System.Collections;
namespace RajendraConsoleApp.Day28_Collection
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Pen");
            arrayList.Add("Pencil");
            arrayList.Add("Eraser");
            arrayList.Add("Sharpner");
            arrayList.Add("Scale");
            
            Console.WriteLine("Arraylist before removing'Eraser': ");
            foreach (string i in arrayList)
            {
                Console.WriteLine(i);
            }
            arrayList.Remove("Eraser");
            Console.WriteLine("Arraylist after removing'Eraser': " );
            foreach (string i in arrayList)
            {
                Console.WriteLine(i);
                
            }
            Console.ReadLine();
        }
    }
}