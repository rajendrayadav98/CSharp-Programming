// Create a Hashtable that stores Book IDs (int) as keys and Book Titles (string) as values.

// Add the following book records to the Hashtable:

// 201 → "The Alchemist"

// 202 → "The Hobbit"

// 203 → "Pride and Prejudice"

// 204 → "AgniPankh"

// 205 → "Shyamchi Aai"
// Prompt the user to enter a Book ID.

// Use the ContainsKey() method to check if the entered ID exists in the Hashtable.

// If it exists, display the corresponding book title.

// If it does not exist, display an appropriate message.

// Output:-
// Enter a Book ID to search: 204
// Book found! Title: AgniPankh
// ----------------------------------------------------------
using System;
using System.Collections;
namespace RajendraConsoleApp.Day28_Collection
{
    internal class Class9
    {
        static void Main(string[] args)
        {
            Hashtable book = new Hashtable();
            book.Add(201, "The Alchemist");
            book.Add(202, "The Hobbit");
            book.Add(203, "Pride and Prejudice");
            book.Add(204, "AgniPankh");
            book.Add(205,"Shyamchi Aai");
            Console.WriteLine("Enter a book id: ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (book.ContainsKey(input))
            {
                Console.WriteLine("Book Tittle: " + book[input]);
            }
            else
            {
                Console.WriteLine("BookId is not found");
            }
        }
    }
}