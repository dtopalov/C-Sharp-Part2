using System;

class PermutationsOfSet
{
    static void Main(string[] args)
    {
        Console.Write("Enter positive integer: ");
        int n = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            arrayOfNumbers[i] = i + 1;
        }
        Perm(n, arrayOfNumbers);
    }

    private static void Perm(int n, int[] array)
    {
        if (n == 0)
        {
            PrintArray(array);
            return;
        }
        for (int i = 0; i < n - 1; i++)
        {
            int temp = array[i];
            array[i] = array[n - 1];
            array[n - 1] = temp;
            Perm(n - 1, array);
            temp = array[i];
            array[i] = array[n - 1];
            array[n - 1] = temp;
        }
        Perm(n-1, array);
    }

    static void PrintArray(int[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }
}