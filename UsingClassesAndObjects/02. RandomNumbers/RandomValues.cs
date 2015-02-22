//Problem 2. Random numbers

//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class RandomValues
{
    static Random rnd = new Random();
    static void Main()
    {
        Console.WriteLine("10 random values from 100 to 200: ");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(GetRandomValue(100, 200));
        }
    }

    static double GetRandomValue(int from, int to)
    {
        double randomValue = rnd.NextDouble()*Math.Min(from, to) + (Math.Max(from, to) - Math.Min(from, to));
        return randomValue;
    }
}
