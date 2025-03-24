using System;

class PalindromeChecker
{
    static void Main()
    {
        Console.WriteLine("Enter a word:");
        string word = Console.ReadLine();
        
        string reversedWord = "";
        
        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversedWord += word[i];
        }
        
        if (word.Equals(reversedWord, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"{word} is a palindrome.");
        }
        else
        {
            Console.WriteLine($"{word} is not a palindrome.");
        }
    }
}
