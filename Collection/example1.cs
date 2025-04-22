// Write a C# program that:

// Creates a non-generic ArrayList.

// Adds five string elements representing  Country names  representing to  the ArrayList.

// Displays all the elements using a foreach loop. 

// Input :
// India
// South Africa
// New Zealand
// Sri Lanka
// Singapore

using System;
using System.Collections;
namespace RajendraConsoleApp.Day28_Collection
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            ArrayList country = new ArrayList();
            country.Add("India");
            country.Add("Sauth Africa");
            country.Add("New Zealand");
            country.Add("Sri Lanka");
            country.Add("Singapoor");
            foreach(string i in country)
            {
                Console.WriteLine(i);
            }
        }
    }
}