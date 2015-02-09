//Problem 17.* Subset K with sum S

//Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//Find in the array a subset of K elements that have sum S or indicate about its absence.

using System;
using System.Linq;

class SubsetKWithSumS
{
    static int N;
    static int K;
    static long S;
    static int[] variations;
    static long[] inputArr;
    static bool distinct = true;
    static bool sumFound = false;

    static void Main()
    {
        Console.Write("Enter a sum to look for: ");
        S = long.Parse(Console.ReadLine());
        Console.Write("Enter size of the subset K: ");
        K = int.Parse(Console.ReadLine());
        Console.Write("Enter an array in the format a, b, c, ...: ");
        string input = Console.ReadLine();       
        string[] numsStr = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        inputArr = new long[numsStr.Length];
        for (int i = 0; i < inputArr.Length; i++)
        {
            inputArr[i] = int.Parse(numsStr[i]);
        }
        variations = new int[K];
        N = inputArr.Length;
        NestedLoops(0);
        if (sumFound == false)
        {
            Console.WriteLine("There is no subset of {0} elements in [{1}] that has a sum of {2}.", K, string.Join(", ", inputArr), S);
        }
    }
    static void NestedLoops(int currentLoop)
    {
        if (currentLoop == K)
        {
            PrintCombinations();
            return;
        }

        for (int i = 1; i <= N; i++)
        {
            variations[currentLoop] = i;
            NestedLoops(currentLoop + 1);
        }
    }

    private static void PrintCombinations()
    {
        //We use the method for finding all the variations and then 
        //from all of the variations of the set, get rid of the ones containing repeating elements, 
        //or consisting of the same elements (for example 1, 2 and 2, 1 - we print 1, 2 only) 
        //to get the final list of combinations.

        distinct = true;
        int[] sorted = (int[]) variations.Clone();
        Array.Sort(sorted);
        for (int i = 1; i < sorted.Length; i++)
        {
            if (sorted[i] == sorted[i - 1] || variations[i] < variations[i - 1])
            {
                distinct = false;
            }
        }
        //print the variations that have the given sum only
        if (distinct)
        {
            if (variations.Sum() == S)
            {
                Console.WriteLine("The sum of the elements of the subset [{0}] is {1}", string.Join(", ", variations), S);
                sumFound = true;
            }
        }
    }
}
