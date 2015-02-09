//Problem 14. Quick sort

//Write a program that sorts an array of strings using the Quick sort algorithm.

using System;

class QuickSort
{
    static void Main(string[] args)
    {
        int[] input = { 2, 1, 2, 4, 3, 5, 2, 6 };    //remove this line if you want to enter another input

        //string input = Console.ReadLine();        //uncomment these lines to enter another array in format x, y, ...
        //string[] numsStr = input.Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);
        //int[] inputArr = new int[numsStr.Length];
        //for (int i = 0; i < input.Length; i++)
        //{
        //    inputArr[i] = int.Parse(numsStr[i]);
        //}

        Console.WriteLine("Unsorted array:[{0}]", string.Join(", ", input));

        // Sort the array
        Quicksort(input, 0, input.Length - 1);

        Console.WriteLine("Sorted array:[{0}]", string.Join(", ", input));

    }

    public static void Quicksort(int[] elements, int left, int right)
    {
        int i = left, j = right;
        int pivot = elements[(left + right)/2];

        while (i <= j)
        {
            while (elements[i].CompareTo(pivot) < 0)
            {
                i++;
            }

            while (elements[j].CompareTo(pivot) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                // Swap
                int tmp = elements[i];
                elements[i] = elements[j];
                elements[j] = tmp;

                i++;
                j--;
            }
        }

        // Recursive calls
        if (left < j)
        {
            Quicksort(elements, left, j);
        }

        if (i < right)
        {
            Quicksort(elements, i, right);
        }
    }
}