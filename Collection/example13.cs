// Write a C# program that create a arraylist,add the following country names India,Aus,NZ,Eng and 
// displays a menu with the following options:

// 1)Add a New Country Name
// Prompt the user to enter a new country name.
// If the country already exists in the list, display a message stating that the country is already present.
// Otherwise, add the new country to the list.

// 2)Insert a Country Name at a Specific Position
// Prompt the user to enter an index position and a country name.
// If the country already exists in the list, prevent duplication.
// Otherwise, insert the country at the specified position.

// 3)Remove a Country Name by Name
// Prompt the user to enter a country name.
// If it exists, remove it from the list and display a success message.
// If it doesn't exist, show an error message.

// 4)Display All World Cup Country Names
// Display the list of all countries currently stored in the ArrayList.

// After each operation completed, then you should ask the user whether they want to continue (Y/y for Yes).if user give input Y/y then again you have to show the all Options.

// OutPut:-
// List of Options:
// ------------------------------
//  1.Add a new Countryname to the list
//  2.Insert new Countryname at anyposition from the list
//  3.Remove any Countryname from the list using Countryname
//  4.Display all WorldCup Countriesname
// ----------------------------------------------------------
// Enter your OPTION =1
// Enter Country Name to add
// West Indies
// -----------------------------------------------
// Country Name:-
// India
// Aus
// NZ
// Eng
// West Indies
// ---------------------------------
// Press only Y/y(Yes) to Continue=y


using System;
using System.Collections;

internal class class7
{
    static void Main()
    {
        ArrayList countries = new ArrayList() { "India", "Aus", "NZ", "Eng" };
        string userChoice;

        do
        {
            Console.WriteLine("\nList of Options:");
            Console.WriteLine("------------------------------");
            Console.WriteLine(" 1. Add a new Countryname to the list");
            Console.WriteLine(" 2. Insert new Countryname at any position from the list");
            Console.WriteLine(" 3. Remove any Countryname from the list using Countryname");
            Console.WriteLine(" 4. Display all WorldCup Countriesname");
            Console.WriteLine("----------------------------------------------------------");
            Console.Write("Enter your OPTION = ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("Enter Country Name to add: ");
                    string newCountry = Console.ReadLine();
                    if (countries.Contains(newCountry))
                    {
                        Console.WriteLine("Country already exists in the list.");
                    }
                    else
                    {
                        countries.Add(newCountry);
                        Console.WriteLine("Country added successfully.");
                    }
                    break;

                case "2":
                    Console.WriteLine("Enter the index position:");
                    int position = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the insert country:");
                    string insert = Console.ReadLine();
                    if (countries.Contains(insert))
                    {
                        Console.WriteLine($"Country {insert} already present in the list.");
                    }
                    else
                    {
                        countries.Insert(position, insert);
                        Console.WriteLine($"Country {insert} at {position} in list");
                    }
                    break;

                case "3":
                    Console.Write("Enter Country Name to remove: ");
                    string countryToRemove = Console.ReadLine();
                    if (countries.Contains(countryToRemove))
                    {
                        countries.Remove(countryToRemove);
                        Console.WriteLine("Country removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Country not found in the list.");
                    }
                    break;

                case "4":
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("Country Name:-");
                    foreach (string country in countries)
                    {
                        Console.WriteLine(country);
                    }
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose from 1 to 4.");
                    break;
            }

            Console.WriteLine("\nDo you want to continue? (Y/y for Yes): ");
            userChoice = Console.ReadLine();
        }
        while (userChoice.Equals("Y", StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("Program Ended.");
    }
}