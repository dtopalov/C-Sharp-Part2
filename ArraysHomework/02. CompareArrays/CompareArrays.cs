//Problem 2.

//Write a program that reads two arrays from the console and compares them element by element.

using System;

class CompareArrays
{
    static void Main()
    {
        Console.Write("Enter length of the first array: ");
        int firstArrayLength = int.Parse(Console.ReadLine());
        Console.Write("Enter length of the second array: ");
        int secondArrayLength = int.Parse(Console.ReadLine());
        bool arraysAreEqual = true;

        int[] firstArray = new int[firstArrayLength];
        int[] secondArray = new int[secondArrayLength];

        if (firstArray.Length == secondArray.Length)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write("firstArray[{0}] = ", i);
                firstArray[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < secondArray.Length; j++)
            {
                Console.Write("secondArray[{0}] = ", j);
                secondArray[j] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    arraysAreEqual = false;
                    break;
                }
            }
        }
        else
        {
            arraysAreEqual = false;
        }
        Console.WriteLine("Arrays are equal? --> {0}", arraysAreEqual);
    }
}
