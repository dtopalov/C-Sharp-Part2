//Problem 12.

//Write a program that creates an array containing all letters from the alphabet (A-Z). 
//Read a word from the console and print the index of each of its letters in the array.

using System;

class ArrayOfLetters
{
    static void Main(string[] args)
    {
        char[] letters = new char[26];
        for (int i = 0; i < 26; i++)
        {
            letters[i] = (char)(i + 65);
        }
        Console.WriteLine("Please enter a word: ");
        string input = Console.ReadLine().ToUpper();
        Console.Write("The indices of the letters of the entered word are: ");
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < letters.Length; j++)
            {
                if (input[i] == letters[j])
                {
                    Console.Write(j);
                    if (i < input.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }
            }
        }
        Console.WriteLine();
    }
}
