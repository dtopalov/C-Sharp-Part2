//Problem 2. Reverse string

//Write a program that reads a string, reverses it and prints the result at the console.

using System;
using System.Linq;

class ReverseString
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        string reversed = string.Join("", input.Reverse());
        Console.WriteLine("The reversed string: {0}", reversed);
    }
}
