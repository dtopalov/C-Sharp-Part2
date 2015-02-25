//Problem 10. Unicode characters

//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.

using System;

class UnicodeCharacters
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            Console.Write("\\u{0:X4}", Convert.ToUInt16(input[i]));
        }
        Console.WriteLine();
    }
}

