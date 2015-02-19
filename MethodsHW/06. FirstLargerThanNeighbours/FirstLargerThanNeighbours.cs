//Problem 6. First larger than neighbours

//Write a method that returns the index of the first element in array that is larger than its neighbours, 
//or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        int[] testArray1 = { 2, -1, 1, 3, -2, 4, 6, 9, 7 };

        Console.WriteLine("The first element, larger than it's neighbours in [{0}]\nis at index: {1}",
           string.Join(", ", testArray1), FindFirstLargerThanNeighbours(testArray1));
    }

    static int FindFirstLargerThanNeighbours(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (LargerThanNeighbours.CheckNeighbours(array, i)) //We use the method from the previuos problem.
            {                                                   //If it finds such index that the element at
                return i;                                       //that index is larger than it's neighbours,
            }                                                   //it returns true, making the current method
        }                                                       //return the index of this element. If there
        return -1;                                              //is no element, larger than it's neighbours,
    }                                                           //the current method returns -1.
}
