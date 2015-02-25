//Problem 8. Extract sentences

//Write a program that extracts from a given text all sentences containing given word.

using System;
using System.Collections.Generic;
using System.Linq;

class ExtractSentences
{
    static void Main()
    {
        Console.Write("Enter text: ");
        //Get an array of sentences
        string[] input = Console.ReadLine().Trim().Split(new []{'.', '?', '!'}, StringSplitOptions.RemoveEmptyEntries);
        Console.Write("Enter a word to look for: ");
        string word = Console.ReadLine();
        var result = new List<string>();

        for (int i = 0; i < input.Length; i++)
        {
            string[] words = input[i].Trim().Split(new[] { ' ', ',', ':', ';', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Contains(word))
            {
                result.Add(input[i]);
                result.Add(".");
            }
        }

        Console.WriteLine(string.Join("", result));
    }
}
