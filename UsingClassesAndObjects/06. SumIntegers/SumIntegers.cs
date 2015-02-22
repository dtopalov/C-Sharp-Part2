using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class SumIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter array of integers, separated by spaces (1 2 3 ...): ");
        string input = Console.ReadLine();

        Console.WriteLine("The sum of the entered numbers is: {0}", SumArray(input));
        
    }

    public static long SumArray(string numbers)
    {
        int[] array = numbers.Split(' ').Select(int.Parse).ToArray();
        return array.Sum();
    }
}
