//Problem 3. Sequence in matrix
//
//We are given a matrix of strings of size N x M. Sequences in the matrix we define 
//as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.

using System;
using System.Collections.Generic;

class SequenceInMatrix
{
    static void Main()
    {
        string[,] input =
        {
            {"ha", "ha", "ho", "hi"},
            {"fo", "hr", "ha", "xx"},
            {"xxx", "ha", "ho", "ha"}
        };
        //Comment the above lines and uncomment the following to enter a matrix of your choice

        //Console.Write("Enter a number for matrix rows: ");
        //int rows = int.Parse(Console.ReadLine());
        //Console.Write("Enter a number for matrix columns: ");
        //int cols = int.Parse(Console.ReadLine());
        //string[,] input = new string[rows,cols];

        //for (int i = 0; i < rows; i++)
        //{
        //    for (int j = 0; j < cols; j++)
        //    {
        //        Console.Write("Enter Matrix[{0},{1}]: ", i, j);
        //        input[i, j] = Console.ReadLine();              
        //    }
        //}

        int bestSequence = 1;
        int currentSequence = 1;
        int currentRow = 0;
        int currentCol = 0;
        int bestRow = 0;
        int bestCol = 0;

        //Check for sequences horizontally
        for (int i = 0; i < input.GetLength(0); i++)
        {
            for (int j = 1; j < input.GetLength(1); j++)
            {
                currentCol = j;
                while (j < input.GetLength(1) && input[i, j] == input[i, j - 1])
                {
                    j++;
                    currentSequence++;
                    if (currentSequence > bestSequence)
                    {
                        bestSequence = currentSequence;
                        bestRow = i;
                        bestCol = j - 1;
                    }
                }
                j = currentCol;
                currentSequence = 1;
            } 
        }
        //Check for sequences vertically
        for (int i = 1; i < input.GetLength(0); i++)
        {
            for (int j = 0; j < input.GetLength(1); j++)
            {
                currentRow = i;
                while (i < input.GetLength(0) && input[i, j] == input[i - 1, j])
                {
                    i++;
                    currentSequence++;
                    if (currentSequence > bestSequence)
                    {
                        bestSequence = currentSequence;
                        bestRow = i - 1;
                        bestCol = j;
                    }
                }
                i = currentRow;
                currentSequence = 1;
            }
        }
        //Check for sequences diagonally from left to right (\)
        for (int i = 0; i < input.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < input.GetLength(1) - 1; j++)
            {
                currentRow = i;
                currentCol = j;
                while (i < input.GetLength(0) - 1 && j < input.GetLength(1) - 1 && input[i, j] == input[i + 1, j + 1])
                {
                    i++;
                    j++;
                    currentSequence++;
                    if (currentSequence > bestSequence)
                    {
                        bestSequence = currentSequence;
                        bestRow = i;
                        bestCol = j;
                    }
                }
                i = currentRow;
                j = currentCol;
                currentSequence = 1;
            }
        }

        //Check for sequences diagonally from right to left (/)
        for (int i = 0; i < input.GetLength(0); i++)
        {
            for (int j = 1; j < input.GetLength(1); j++)
            {
                currentRow = i;
                currentCol = j;
                while (i < input.GetLength(0) - 1 && j > 0 && input[i, j] == input[i + 1, j - 1])
                {
                    i++;
                    j--;
                    currentSequence++;
                    if (currentSequence > bestSequence)
                    {
                        bestSequence = currentSequence;
                        bestRow = i;
                        bestCol = j;
                    }
                }
                i = currentRow;
                j = currentCol;
                currentSequence = 1;
            }
        }

        for (int i = 0; i < bestSequence; i++)
        {
            Console.Write(input[bestRow, bestCol]);
            if (i < bestSequence - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}
