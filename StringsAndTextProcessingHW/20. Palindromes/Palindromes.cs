//Problem 20. Palindromes

//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

using System;
using System.Collections.Generic;
using System.Linq;

class Palindromes
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string input = Console.ReadLine();
        var separators = new HashSet<char>();

        for (int i = 0; i < input.Length; i++)
        {
            if (!char.IsLetter(input[i]))
            {
                separators.Add(input[i]);
            }
        }
        string[] modifiedInput = input.Trim().Split(separators.ToArray(), StringSplitOptions.RemoveEmptyEntries);

        modifiedInput = modifiedInput.Where(x => x.ToLower() == string.Join("", x.Reverse()).ToLower()).ToArray();
        Console.WriteLine(string.Join(", ", modifiedInput));
    }
}
