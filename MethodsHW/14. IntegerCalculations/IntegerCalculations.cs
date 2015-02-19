using System;
using System.Collections.Generic;
using System.Linq;

class IntegerCalculations
{
    static void Main()
    {
        Console.WriteLine("Enter a sequence of integers, separated by spaces: ");
        int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

        Console.WriteLine("Min: {0}\nMax: {1}\nAverage: {2}\nProduct: {3}", ShowMin(input), ShowMax(input), CalcAverage(input), CalcProduct(input));
    }

    static int ShowMin(params int[] array)
    {
        return array.Min();
    }
    static int ShowMax(params int[] array)
    {
        return array.Max();
    }

    static double CalcAverage(params int[] array)
    {
        List<int> list = array.ToList();
        return list.Average();
    }
    static long CalcProduct(params int[] array)
    {
        long product = 1;
        foreach (var item in array)
        {
            product *= item;
        }
        return product;
    }
}

