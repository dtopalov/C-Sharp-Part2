//Problem 2. Binary to decimal

//Write a program to convert binary numbers to their decimal representation.

using System;

class BinToDec
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string binaryNumber = Console.ReadLine();

        Console.WriteLine("The decimal representation of\n{0}\nis {1}", binaryNumber, BinaryToDecimalConverter(binaryNumber));
    }

    static long BinaryToDecimalConverter(string binaryNumber)
    {
        long result = 0;
        for (int i = 0; i < binaryNumber.Length; i++)
        {
            result += (long.Parse(binaryNumber[binaryNumber.Length - 1 - i].ToString())) * (long)Math.Pow(2, i);
        }
        return result;
    }
}
