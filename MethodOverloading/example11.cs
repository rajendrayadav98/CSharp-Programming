// Create a class "Library" :-
// Method: RegisterMember(string memberName)

// Prints a confirmation message for the new member.

// Create a Class Membership (Inherits from Library):
// Protected field: borrowedBooks (int)

// Create Method: Method:- BorrowBooks(int count)
//                Return Type:-Void

// store the count into the borrowedBooks field and displays a message for borrowed books.

// Create a Class PremiumMember (Inherits from Membership):
// Instance variable: private double finePerDay = 2.0;

// Create Method: Method:- CalculateFine(int lateDays)
//                Return Type:-Void

// Calculates and prints the fine using the formula:
// Fine = borrowedBooks × finePerDay × lateDays

// In the Main() method:
// Create a PremiumMember object.
// call the methods  RegisterMember,BorrowBooks and CalculateFine


using System;

// Base class
class Library
{
    public void RegisterMember(string memberName)
    {
        Console.WriteLine($"Member '{memberName}' registered successfully!");
    }
}

// Intermediate class inheriting from Library
class Membership : Library
{
    protected int borrowedBooks;

    public void BorrowBooks(int count)
    {
        borrowedBooks = count;
        Console.WriteLine($"{count} book(s) borrowed.");
    }
}

// Derived class from Membership
class PremiumMember : Membership
{
    private double finePerDay = 2.0;

    public void CalculateFine(int lateDays)
    {
        double fine = borrowedBooks * finePerDay * lateDays;
        Console.WriteLine($"Total fine for {lateDays} late day(s): ${fine}");
    }
}

// Main class
class Task
{
    static void Main(string[] args)
    {
        // Create PremiumMember object
        PremiumMember member = new PremiumMember();

        // Call methods
        member.RegisterMember("Alice");
        member.BorrowBooks(3);
        member.CalculateFine(5);
    }
}
