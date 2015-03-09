//Problem 5. Maximal area sum

//Write a program that reads a text file containing a square matrix of numbers.
//Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file.

using System;
using System.IO;
using System.Linq;

class MaxAreaSum
{
    static void Main()
    {
        StreamReader sr = new StreamReader(@"..\..\sampleMatrix.txt");
        int squareMatrixSide = int.Parse(sr.ReadLine());
        int[,] squareMatrix = new int[squareMatrixSide,squareMatrixSide];

        for (int i = 0; i < squareMatrix.GetLength(0); i++)
        {
            string inputLine = sr.ReadLine();
            for (int j = 0; j < squareMatrix.GetLength(1); j++)
            {
                squareMatrix[i, j] = inputLine.Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray()[j];
            }
        }

        sr.Close();
        PrintMatrix(squareMatrix);
        long maxSum = CalcMaxSum(squareMatrix);

        using (StreamWriter sw = new StreamWriter(@"..\..\result.txt"))
        {
            sw.WriteLine(maxSum);
        }

        using (StreamReader sr1 = new StreamReader(@"..\..\result.txt"))
        {
            Console.WriteLine("Max 2x2 area sum is: {0}", sr1.ReadLine());
        }

    }

    public static long CalcMaxSum(int[,] matrix)
    {
        long maxSum = long.MinValue;
        long currentSum = 0;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
        }

        return maxSum;
    }

    public static void PrintMatrix(int[,] matrix)
    {
        Console.WriteLine("Matrix:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j]);
                if (j < matrix.GetLength(1) - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}