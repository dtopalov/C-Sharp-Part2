//Problem 2. Get largest number

//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;

class LargestNumber
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        int result = GetMax(firstNumber, GetMax(secondNumber, thirdNumber));

        Console.WriteLine("The largest from {0}, {1}, and {2} is {3}", firstNumber, secondNumber, thirdNumber, result);
    }

    static int GetMax(int first, int second)
    {
        if (first >= second)
        {
            return first;
        }
        else
        {
            return second;
        }
    }
}
