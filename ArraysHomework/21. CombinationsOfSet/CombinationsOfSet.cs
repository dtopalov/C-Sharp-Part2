//Problem 21.* Combinations of set

//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].

using System;

class CombinationsOfSet
{
    static int N;
    static int K;
    static int[] variations;
    static bool distinct = true;

    static void Main()
    {
        Console.Write("Enter N for the set of numbers [1, N]: ");
        N = int.Parse(Console.ReadLine());

        Console.Write("Enter K for the combinations of K elements from the set: ");
        K = int.Parse(Console.ReadLine());

        variations = new int[K];

        NestedLoops(0);
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

    static void PrintCombinations()
    {
        //We use the method for finding all the variations from the previous problem and then 
        //from all of the variations of the set, get rid of the ones containing repeating elements, 
        //or consisting of the same elements (for example from 1, 2 and 2, 1 - we print 1, 2 only) 
        //to get the final list of combinations.

        distinct = true;
        int[] sorted = (int[])variations.Clone();
        Array.Sort(sorted);
        for (int i = 1; i < sorted.Length; i++)
        {
            if (sorted[i] == sorted[i - 1] || variations[i] < variations[i-1])
            {
                distinct = false;
            }
        }
        //print the combinations only
        if (distinct)
        {
            for (int i = 0; i < K; i++)
            {
                Console.Write("{0} ", variations[i]);
            }
            Console.WriteLine();
        }
    }
}
