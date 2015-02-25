//Problem 9. Forbidden words

//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.

using System;

class ForbiddenWords
{
    static void Main()
    {
        Console.WriteLine("Enter a list of forbidden words, separated by a space and/or ',': ");
        string[] forbiddenWords = Console.ReadLine().Trim().Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Enter the text: ");
        string text = Console.ReadLine();

        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            text = text.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
        }
        Console.WriteLine();
        Console.WriteLine(text);
    }
}
