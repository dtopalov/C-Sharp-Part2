//Problem 13. Reverse sentence

//Write a program that reverses the words in given sentence.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ReverseSentence
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence: ");
        string[] input = Console.ReadLine().Split(' ');
        input = input.Reverse().ToArray();
        char[] ending = {'.', '?', '!'};
        string endingOfReversed = string.Empty;
        char[] punctuation = {',', ':', ';', '-'};
        var result = new List<string>();
        var word = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            word.Clear();
            for (int j = 0; j < input[i].Length; j++)
            {
                if (!punctuation.Contains(input[i][j]) && !ending.Contains(input[i][j]))
                {
                    word.Append(input[i][j]);
                }
                else if(i == 0 && ending.Contains(input[i][j]))
                {
                    endingOfReversed += input[i][j];
                }
                else if (i > 0 && punctuation.Contains(input[i][j]))
                {
                    result[i - 1] += input[i][j];
                }
            }
            result.Add(word.ToString());
            if (i == input.Length - 1)
            {
                result[i] += endingOfReversed;
            }
        }

        Console.WriteLine(string.Join(" ",result));
    }
}
