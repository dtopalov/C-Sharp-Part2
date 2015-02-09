//Problem 10.

//Write a program that finds in given array of integers a sequence of given sum S (if present). 
//Example: {4, 3, 1, 4, 2, 5, 8}, S=11 ? {4, 2, 5}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SumOfSequence
{
    static void Main()
    {
        int[] array = {4, 3, 1, 4, 2, 5, 8};
        int givenSum = 11;
        int currentStart = 0; 
        int currentEnd = 0;
        bool sumFound = false;

        for (int i = 0; i < array.Length; i++)
        {
            if (sumFound)
            {
                break;
            }
            currentStart = i;
            long currentSum = array[i];
            for (int j = i + 1; j < array.Length; j++)
            {
                if (currentSum < givenSum)
                {
                    currentSum += array[j];
                    if (currentSum == givenSum)
                    {
                        currentEnd = j;
                        sumFound = true;
                        break;
                    }
                }
                else
                {
                    currentSum = array[j];
                }
            }
        }
        if (sumFound)
        {
            int[] wantedSequence = new int[currentEnd - currentStart + 1];
            for (int i = 0; i < wantedSequence.Length; i++)
            {
                wantedSequence[i] = array[currentStart + i];
            }
            Console.WriteLine("The sequence [{0}] has the given sum of {1}", String.Join(", ", wantedSequence), givenSum);
        }
        else
        {
            Console.WriteLine("There is no sequence with sum = {0} in the array [{1}].", givenSum, String.Join(", ", array));
        }
    }
}