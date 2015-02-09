//Problem 6.

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;

class MaxSum
{
    static void Main()
    {
        Console.Write("Please enter the number of elements (N) of the array ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Please enter the number of elements K (0 < K < N): ");
        int K = int.Parse(Console.ReadLine());
        int[] array = new int[N];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        long maxSum = 0;
        for (int i = 0; i < K; i++)
        {
            maxSum += array[array.Length - i - 1];
        }
        Console.WriteLine("The max sum of {0} elements in the array is {1}.", K, maxSum);
    }
}
