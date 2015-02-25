//Problem 6. String length

//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.

using System;

class StringLength
{
    static void Main()
    {
        string input;
        do
        {
            Console.Write("Enter a string consisting of no more than 20: ");
            input = Console.ReadLine();            
        } while (input.Length > 20);

        if (input.Length < 20)
        {
            input = new string('*', 20 - input.Length) + input;
        }
        Console.WriteLine(input);
    }
}

