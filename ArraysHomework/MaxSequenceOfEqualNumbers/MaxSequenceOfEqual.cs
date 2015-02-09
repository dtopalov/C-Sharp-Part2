//Problem 4.

//Write a program that finds the maximal sequence of equal elements in an array.

using System;

class MaxSequenceOfEqual
{
    static void Main()
    {
        int[] array = {2, 1, 1, 2, 3, 3, 2, 2, 2, 1};
        int currentSequence = 1;
        int maxSequence = 1;
        int maxSequenceStartIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
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
            longestSequence[i] = array[maxSequenceStartIndex];
        }


        Console.WriteLine("The longest sequence of equal elements in [{0}] consists of {1} elements - [{2}].", String.Join(", ", array), maxSequence, String.Join(", ", longestSequence));
    }
}
