// Write a C# program that:

// Creates an ArrayList and adds the following integers: 6, 3, 2, 8, 4

// Sorts the elements manually in ascending order without using any built-in sorting methods like Sort()

// Displays the sorted list after sorting is complete

// Output:-

// Before Sorting
// 6
// 3
// 2
// 8
// 4
// After sorting
// 2
// 3
// 4
// 6
// 8

using System;
using System.Collections;
namespace RajendraConsoleApp.Day28_Collection
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(6);
            arrayList.Add(3);
            arrayList.Add(2);
            arrayList.Add(8);
            arrayList.Add(4);
            Console.WriteLine("Araay list before  sorting: ");
            foreach (int i in arrayList)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < arrayList.Count; i++)
            {
                for (int j = i + 1; j < arrayList.Count; j++)
                {
                    if ((int)arrayList[i] > (int)arrayList[j])
                    {
                        // Swap numbers[i] and numbers[j]
                        int temp = (int)arrayList[i];
                        arrayList[i] = arrayList[j];
                        arrayList[j] = temp;
                    }
                }
            }
            Console.WriteLine("After sorting: ");
            foreach(int i in arrayList)
            {
                Console.WriteLine(i);
            }
        }
    }
}