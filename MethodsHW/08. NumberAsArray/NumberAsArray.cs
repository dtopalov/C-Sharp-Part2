//Problem 8. Number as array

//Write a method that adds two positive integer numbers represented as arrays
//of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Linq;

class NumberAsArray
{
    static void Main()
    {
        Console.Write("Enter first positive integer number: ");
        string firstNumber = Console.ReadLine();

        Console.Write("Enter second positive integer number: ");
        string secondNumber = Console.ReadLine();

        Console.WriteLine(AddNumbers(firstNumber, secondNumber)); //method is working directly with strings, no need
    }                                                             //to convert input to array etc.  

    static string AddNumbers(string first, string second)
    {
        string result = "";
        int lengthDifference = Math.Max(first.Length, second.Length) //if one of the numbers is shorter, fill it up
            - Math.Min(first.Length, second.Length);                 //with zeroes on the left until both have equal
                                                                     //length
        if (first.Length > second.Length)
        {
            second = new string('0', lengthDifference) + second;
        }
        else
        {
            first = new string('0', lengthDifference) + first;
        }
        int remainder = 0;
        int number = 0;
        for (int i = 0; i < first.Length; i++)
        {
            
            number = int.Parse(first[first.Length - 1 - i].ToString()) +
                         int.Parse(second[second.Length - 1 - i].ToString()) + remainder;
            remainder = number/10;

            if (number%10 != 0)
            {
                result = number%10 + result;
            }
            else
            {
                result = 0 + result;
            }

            if (i == first.Length - 1 && remainder == 1)
            {
                result = remainder + result;
            }
        }

        return result;
    }
}

