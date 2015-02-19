//Problem 7. Reverse number

//Write a method that reverses the digits of given decimal number.

using System;

class ReverseDigits
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int input = Math.Abs(int.Parse(Console.ReadLine()));

        Console.WriteLine("The digits of {0} in reversed order: {1}", input, ReverseNumberDigits(input));
    }

    private static int ReverseNumberDigits(int number)
    {
        string result = "";

        for (int i = 0; i < number.ToString().Length; i++)
        {
            result = number.ToString()[i] + result;
        }

        return int.Parse(result);
    }
}
