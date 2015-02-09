//Problem 5.

//Write a program that finds the maximal increasing sequence in an array.

using System;

class MaxSequenceOfIncreasing
{
    static void Main()
    {
        int[] array = {3, 2, 3, 4, 2, 2, 4};
        int currentSequence = 1;
        int maxSequence = 1;
        int maxSequenceStartIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[i - 1])
            {
                currentSequence++;
            }
            else
            {
                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                    maxSequenceStartIndex = i - maxSequence;
                }
                currentSequence = 1;
            }
        }

        int[] longestSequence = new int[maxSequence];
        for (int i = 0; i < longestSequence.Length; i++)
        {
            longestSequence[i] = array[maxSequenceStartIndex + i];
        }


        Console.WriteLine("The longest sequence of increasing elements in [{0}] consists of {1} elements - [{2}].", String.Join(", ", array), maxSequence, String.Join(", ", longestSequence));
    }
}