//Problem 3.

//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareArrays
{
    static void Main()
    {
        Console.Write("Enter length of the first array: ");
        int firstArrayLength = int.Parse(Console.ReadLine());
        Console.Write("Enter length of the second array: ");
        int secondArrayLength = int.Parse(Console.ReadLine());
        int length = firstArrayLength;
        bool equal = true;

        char[] firstArray = new char[firstArrayLength];
        char[] secondArray = new char[secondArrayLength];

        if (firstArray.Length != secondArray.Length)
        {
            length = Math.Min(firstArray.Length, secondArray.Length);
        }

        for (int i = 0; i < firstArray.Length; i++)
        {
            Console.Write("firstArray[{0}] = ", i);
            firstArray[i] = Console.ReadLine().ToCharArray()[0];
        }
        for (int j = 0; j < secondArray.Length; j++)
        {
            Console.Write("secondArray[{0}] = ", j);
            secondArray[j] = Console.ReadLine().ToCharArray()[0];
        }
        for (int i = 0; i < length; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                equal = false;
                if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("firstArray is smaller.");
                    break;
                }
                Console.WriteLine("secondArray is smaller.");
                break;
            }
        }
        if (equal)
        {
            Console.WriteLine("The arrays are equal.");
            if (firstArray.Length < secondArray.Length)
            {
                Console.WriteLine("firstArray is smaller.");
            }
            if(secondArray.Length < firstArray.Length)
            {
                Console.WriteLine("secondArray is smaller.");
            }
        }
    }
}
