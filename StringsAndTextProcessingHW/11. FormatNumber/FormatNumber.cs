//Problem 11. Format number

//Write a program that reads a number and prints it as a decimal number, hexadecimal number, 
//percentage and in scientific notation.
//Format the output aligned right in 15 symbols.

using System;
using System.Globalization;
using System.Threading;

class FormatNumber
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter a number: ");
        double input = double.Parse(Console.ReadLine());

        Console.WriteLine("{0, 15}\n{1, 15}\n{0, 15:P}\n{0, 15:e2}", input, Convert.ToString((int)input, 16));
    }
}