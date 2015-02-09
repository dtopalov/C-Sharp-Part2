//Problem 8.

//Write a program that finds the sequence of maximal sum in given array. 
//Example: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} ? {2, -1, 6, 4} 
//Can you do it with only one loop (with single scan through the elements of the array)?

using System;
using System.Collections.Generic;

class MaxSumSequence
{
    static void Main()
    {
        //string input = "2, 3, -6, -1, 2, -1, 6, 4, -8, 8";
        //string[] numsStr = input.Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);
        //int[] nums = new int[numsStr.Length];
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    nums[i] = int.Parse(numsStr[i]);
        //}
        int[] array = {2, 3, -6, -1, 2, -1, 6, 4, -8, 8};
        long maxSum = array[0];
        long currentSum = array[0];
        int currentSequenceStart = 0;
        int maxSumSequenceStart = 0;
        int maxSumSequenceLength = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == 0)
            {
                continue;
            }
            if ((currentSum + array[i] > currentSum) || (array[i-1] >= array[i]))
            {
                currentSum += array[i];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxSumSequenceStart = currentSequenceStart;
                    maxSumSequenceLength++;
                }
            }
            else
            {
                i++;
                currentSequenceStart = i;                
                currentSum = array[i];
            }
        }
        
        int[] maxSequence = new int[maxSumSequenceLength];
        for (int i = 0; i < maxSequence.Length; i++)
        {
            maxSequence[i] = array[maxSumSequenceStart + i];
        }

        Console.WriteLine("The max sum (sum = {2}) sequence in the array [{0}] is [{1}]",String.Join(", ",array), String.Join(", ",maxSequence), maxSum);
    }
}