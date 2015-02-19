//Problem 5. Larger than neighbours

//Write a method that checks if the element at given position in given array of 
//integers is larger than its two neighbours (when such exist).

using System;

public class LargerThanNeighbours
{
    static void Main()
    {
        int[] testArray1 = {2, 5, 1, 3, -2, 4, 6, 9, 7};
        
        for (int i = 0; i < testArray1.Length; i++)
        {
            Console.WriteLine("The element at index {0} in [{1}]\nis larger than it's neighbours --> {2}",
            i, string.Join(", ",testArray1), CheckNeighbours(testArray1, i));
            Console.WriteLine();
        }
    }

    public static bool CheckNeighbours(int[] array, int index)
    {
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (index > 0 && index < array.Length - 1 && array[index] > array[index - 1] && array[index] > array[index + 1])
            {
                return true;
            }
        }
        return false;
    }
}
