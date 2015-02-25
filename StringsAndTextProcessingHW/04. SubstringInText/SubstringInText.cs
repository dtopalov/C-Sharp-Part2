//Problem 4. Sub-string in text

//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

using System;

class SubstringInText
{
    static void Main()
    {
        Console.WriteLine("Enter some text: ");
        string input = Console.ReadLine().ToLower(); //make sure the search will be case-insensitive
        Console.Write("\nEnter a string to search for: ");
        string searched = Console.ReadLine().ToLower(); //see above
        int count = 0;

        for (int i = 0; i < input.Length - searched.Length; i++)
        {
            if (input.Substring(i, searched.Length) == searched)
            {
                count++;
            }
        }

        Console.WriteLine("\n\"{0}\" is found {1} times.", searched, count);
    }
}

