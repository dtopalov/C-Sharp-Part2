//Problem 23. Series of letters

//Write a program that reads a string from the console and replaces all 
//series of consecutive identical letters with a single one.

using System;

class SeriesOfLetters
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string input = Console.ReadLine().Trim();

        string result = string.Empty;

        for (int i = 1; i < input.Length; i++)
        {
            while (i<input.Length && char.IsLetter(input[i]) 
                && input[i].ToString().ToLower() == input[i-1].ToString().ToLower())
            {
                i++;
            }
            result += input[i-1];
            if (i == input.Length - 1 && input[i].ToString().ToLower() != input[i - 1].ToString().ToLower())
            {
                result += input[i];
            }
        }

        Console.WriteLine(result);
    }
}
