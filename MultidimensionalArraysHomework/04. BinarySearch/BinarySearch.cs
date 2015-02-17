

using System;
using System.Linq;

class BinarySearch
{
    static void Main()
    {
        int[] numbers = {1, 3, 5, 7, 12}; //comment this line and uncomment the following to enter your own array

        //Console.Write("Enter array size N: ");
        //int N = int.Parse(Console.ReadLine());
        //int[] numbers = new int[N];

        //for (int i = 0; i < N; i++)
        //{
        //    Console.Write("Enter array[{0}]: ", i);
        //    numbers[i] = int.Parse(Console.ReadLine());
        //}

        Console.WriteLine("\nInitial array: {0}", string.Join(", ", numbers));
        Array.Sort(numbers);
        Console.WriteLine("\nSorted array: {0}", string.Join(", ", numbers));

        Console.Write("\nEnter integer K: ");
        int K = int.Parse(Console.ReadLine());

        
        int indexOfK = Array.BinarySearch(numbers, K);
        //Console.WriteLine(indexOfK); //If there is a number == K in the array, indexOfK is the index of the number
                                       //If the array doesn't contain such number, Math.Abs(indexOfK) shows the position K
                                       //would have had if inserted in the sorted array (starting from 1). For example 
                                       //if the sorted array was {1, 3, 5, 7} and K = 4, indexOfK would be -3, meaning that
                                       //4 would be at the third position in the array - after 1 and 3, and before 5.
                                       //If the array doesn't contain a number smaller than K, indexOfK is -1. 
        if (K < numbers[0])
        {
            Console.WriteLine("There is no number in the array that is <= {0}.", K);
        }
        else
        {
            if (indexOfK > 0)
            {
                Console.WriteLine("The largest number in the array <= K is: {0}", numbers[indexOfK]);
            }
            else
            {
                Console.WriteLine("The largest number in the array <= K is: {0}", numbers[Math.Abs(indexOfK + 2)]);       
            }
        }
    }
}
