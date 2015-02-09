//Problem 20.* Variations of set

//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].

using System;

class VariationsOfSet
{
    static int N;
    static int K;
    static int[] variations;

    static void Main()
    {
        Console.Write("Enter N for the set of numbers [1, N]: ");
        N = int.Parse(Console.ReadLine());

        Console.Write("Enter K for the variations of K elements from the set: ");
        K = int.Parse(Console.ReadLine());

        variations = new int[K];

        NestedLoops(0);
    }

    static void NestedLoops(int currentLoop)
    {
        if (currentLoop == K)
        {
            PrintVariations();
            return;
        }

        for (int i = 1; i <= N; i++)
        {
            variations[currentLoop] = i;
            NestedLoops(currentLoop + 1);
        }
    }

    static void PrintVariations()
    {
        Console.WriteLine("{0}", string.Join(", ", variations));
    }
}
