using System;
using System.Linq;

class SortingArray
{
    static void Main()
    {
        Console.WriteLine("Enter an array on a single line, leaving a space between the elements: ");
        string input = Console.ReadLine();

        int[] inputArray = input.Split(' ').Select(x => int.Parse(x)).ToArray();

        Console.WriteLine("Initial array: {0}", string.Join(", ", inputArray));
        Console.WriteLine("Sorted ascending: {0}", string.Join(", ", SortAscending(inputArray)));
        Console.WriteLine("Sorted descending: {0}", string.Join(", ", SortDescending(inputArray)));
    }

    static int ReturnLargestValue(int[] array, int start, int end) //find the largest element in the range 
    {                                                              //array[start] - array[end]
        return array.Skip(start).Take(end - start).Max();
    }

    static int[] SortAscending(int[] array)                     //sort the array using the ReturnLargestValue method
    {                                                           //to find the largest number in the range array[0] - 
        for (int i = 0; i < array.Length; i++)                  //array[n-1], then exchange the places of the rightmost
        {                                                       //and the largest numbers and start again for the remaining
            int max = ReturnLargestValue(array, 0, array.Length - i); //numbers from array[0] to array[n-2] etc.

            array[Array.IndexOf(array, max)] = array[array.Length - i - 1];
            array[array.Length - i - 1] = max;
        }
        return array;
    }

    static int[] SortDescending(int[] array)                    //The same as above, but increasing the starting point
    {                                                           //and putting the next largest number found in front of
        for (int i = 0; i < array.Length; i++)                  //the range
        {                                                      
            int max = ReturnLargestValue(array, i, array.Length);

            array[Array.IndexOf(array, max)] = array[i];
            array[i] = max;
        }
        return array;
    }
}
