using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter number of rows (number >= 3): ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter number of cols (number >= 3): ");
        int cols = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("Enter matrix[{0},{1}]: ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        //or comment the above input and uncomment the following lines to use a sample matrix
        //int[,] matrix = 
        //{
        //    {1, 20, 2, 19, 3},
        //    {18, 4, 17, 5, 16},
        //    {6, 15, 7, 14, 8},
        //    {13, 9, 12, 10, 11}
        //};
        Console.WriteLine("Matrix: ");

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0, 4}", matrix[i, j]);
                if (j < matrix.GetLength(1) - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        long bestSum = long.MinValue;
        long currentSum = 0;
        int bestRow = 0;
        int bestCol = 0;

        for (int i = 0; i < matrix.GetLength(0) - 2; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 2; j++)
            {
                currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    bestRow = i;
                    bestCol = j;
                }
            }
        }
        Console.WriteLine("\nThe 3x3 square with maximal sum = {0} is: ", bestSum);
        for (int i = bestRow; i <= bestRow + 2; i++)
        {
            for (int j = bestCol; j <= bestCol + 2; j++)
            {
                Console.Write("{0, 4}", matrix[i, j]);
                if (j < bestCol + 2)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}
