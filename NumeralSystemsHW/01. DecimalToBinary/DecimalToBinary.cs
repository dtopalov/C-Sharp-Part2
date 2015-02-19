//Problem 1. Decimal to binary

//Write a program to convert decimal numbers to their binary representation.

using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter positive integer: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The binary representation of {0} is:\n{1}", number, DecimalToBinaryConverter(number));
    }

    static string DecimalToBinaryConverter(int input)
    {
        string result = "";
        while (input > 0)
        {
            result = input%2 + result;
            input/=2;
        }
        return result;
    }
}
