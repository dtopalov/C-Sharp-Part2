//Problem 24. Order words

//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;

class OrderWords
{
    static void Main()
    {
        Console.WriteLine("Enter words, separated by spaces: ");
        string[] input = Console.ReadLine().Trim().Split(' ');
        Array.Sort(input);
        Console.WriteLine(string.Join(" ", input));
    }
}
