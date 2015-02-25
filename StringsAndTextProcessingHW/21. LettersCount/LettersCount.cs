//Problem 21. Letters count

//Write a program that reads a string from the console and prints all different letters in 
//the string along with information how many times each letter is found.

using System;
using System.Linq;

class LettersCount
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string input = Console.ReadLine().Trim().ToLower();

        int[] letters = new int[26];

        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsLetter(input[i]))
            {
                letters[input[i] - 'a']++;
            }
        }
        
        for (int i = 0; i < letters.Length; i++)
        {
            if (letters[i] > 0)
            {
                Console.WriteLine("{0} --> {1}", Convert.ToChar(i + 'a'), letters[i]);    
            }
        }
    }
}
