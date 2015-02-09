//Problem 13.* Merge sort

//Write a program that sorts an array of integers using the Merge sort algorithm (find it in Wikipedia).

using System;

class MergeSortAlgorithm
{
    static void Main(string[] args)
    {
        int[] numbers = { 3, 8, 7, 5, 2, 1, 9, 6, 4, 0 };   //Array to be sorted

        Console.Write("Initial array: ");

        for (int i = 0; i < numbers.Length; i++)        //Printing the initial array
        {
            Console.Write(numbers[i]);
            if (i < numbers.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();

        MergeSort(numbers, 0, numbers.Length - 1);      //Sorting the array

        Console.Write("Sorted array: ");
        for (int i = 0; i < numbers.Length; i++)    //Printing the sorted array
        {
            Console.Write(numbers[i]);
            if (i < numbers.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }

    static void Merge(int[] numbers, int left, int mid, int right)
    {
        int[] temp = new int[numbers.Length];   //create a temporary array for storing the merged array
        int i, leftEnd, numElements, tempPos;

        leftEnd = (mid - 1);
        tempPos = left;
        numElements = (right - left + 1);

        while ((left <= leftEnd) && (mid <= right)) //traverse both halves at the same time and store the smallest
        {                                           //element to the temporary array
            if (numbers[left] <= numbers[mid])
                temp[tempPos++] = numbers[left++];
            else
                temp[tempPos++] = numbers[mid++];
        }

        while (left <= leftEnd)                     //If there are remaining elements in the left half, store it to temp
            temp[tempPos++] = numbers[left++];

        while (mid <= right)                        //If there are remaining elements in the right half, store it to temp
            temp[tempPos++] = numbers[mid++];

        for (i = 0; i < numElements; i++)           //Store elements of the temp array to the original one
        {
            numbers[right] = temp[right];
            right--;
        }
    }

    static void MergeSort(int[] numbers, int left, int right)   //Recursive merging
    {
        int mid;

        if (right > left)
        {
            mid = (right + left) / 2;
            MergeSort(numbers, left, mid);
            MergeSort(numbers, (mid + 1), right);

            Merge(numbers, left, (mid + 1), right);
        }
    }
}
