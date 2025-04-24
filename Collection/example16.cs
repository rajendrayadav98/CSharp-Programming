// Create a Hashtable that stores country codes (string) as keys and country names (string) as values.

// Add the following entries to the Hashtable:

// "IN" → "India"

// "US" → "United States"

// "UK" → "United Kingdom"

// Prompt the user to enter a country code.

// Check if the code exists in the Hashtable using ContainsKey().

// If the key exists, remove that entry using Remove() and display a success message.

// If the key does not exist, display an appropriate message saying the key is not found.

// Output:-
// Enter country code to remove: US
// Entry with code 'US' has been removed.
// or 
// Enter country code to remove: CA
// Key not found in Hashtable.

using System;
using System.Collections;
namespace RajendraConsoleApp.Day28_Collection
{
    internal class Class10
    {
        static void Main(string[] args)
        {
            Hashtable codes = new Hashtable();
            codes.Add("IN","INDIA");
            codes.Add("US", "Unites States");
            codes.Add("UK", "UNITED KINGDOM");
            Console.WriteLine("Enter the country code which you want to remove: ");
            string code = Console.ReadLine();
            if (codes.ContainsKey(code))
            {
                codes.Remove(code);
                Console.WriteLine($"Succesfully remove the country code:'{code}'");
            }
            else
            {
                Console.WriteLine($"Country code '{code}' not found in the list");
            }
        }
    }
}