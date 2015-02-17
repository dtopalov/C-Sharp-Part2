//Problem 19.** Spiral Matrix

//Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix 
//holding the numbers from 1 to n*n in the form of square spiral like in the examples below.

using System;

class FillTheMatrix
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int input = int.Parse(Console.ReadLine());
        int[,] matrix = new int[input, input];
        int currentRow = 0;
        int currentCol = 0;
        string direction = "down";
        for (int i = 0; i < input * input; i++) //fill matrix d) using directions
        {
            switch (direction)
            {
                case "right":
                    if (currentCol == input || matrix[currentRow, currentCol] != 0)
                    {
                        direction = "up";
                        currentCol--;
                        currentRow--;
                        if (i < input * input - 1)
                        {
                            i--;
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = i + 1;
                        }
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = i + 1;
                        currentCol++;
                    }
                    break;
                case "down":
                    if (currentRow == input || matrix[currentRow, currentCol] != 0)
                    {
                        direction = "right";
                        currentCol++;
                        currentRow--;
                        if (i < input * input - 1)
                        {
                            i--;
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = i + 1;
                        }
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = i + 1;
                        currentRow++;
                    }
                    break;
                case "left":
                    if (currentCol < 0 || matrix[currentRow, currentCol] != 0)
                    {
                        direction = "down";
                        currentRow++;
                        currentCol++;
                        if (i < input * input - 1)
                        {
                            i--;
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = i + 1;
                        }
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = i + 1;
                        currentCol--;
                    }
                    break;
                case "up":
                    if (currentRow < 0 || matrix[currentRow, currentCol] != 0)
                    {
                        direction = "left";
                        currentCol--;
                        currentRow++;
                        if (i < input * input - 1)
                        {
                            i--;
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = i + 1;
                        }
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = i + 1;
                        currentRow--;
                    }
                    break;
            }
        }

        int[,] matrixA = new int[input, input];
        currentRow = 0;
        currentCol = 0;
        for (int i = 1; i <= input * input; i++) //fill matrix a)
        {
            matrixA[currentRow, currentCol] = i;
            currentRow++;
            if (currentRow == input)
            {
                currentCol++;
                currentRow -= input;
            }
        }

        Console.WriteLine("a)");

        for (int row = 0; row < input; row++) //print matrix a)
        {
            for (int col = 0; col < input; col++)
            {
                Console.Write("{0, 4}", matrixA[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine(new string('-', 25));

        int[,] matrixB = new int[input, input];
        currentRow = 0;
        currentCol = 0;
        bool flag = false;
        for (int i = 1; i <= input * input; i++) //fill matrix b)
        {
            matrixB[currentRow, currentCol] = i;
            if (i % input == 0)
            {
                flag = !flag;
                currentCol++;
            }
            if (flag)
            {
                if (i % input == 0)
                {
                    continue;
                }
                currentRow--;
            }
            else
            {
                if (i % input == 0)
                {
                    continue;
                }
                currentRow++;
            }
        }
        Console.WriteLine("b)");
        for (int row = 0; row < input; row++) //print matrix b)
        {
            for (int col = 0; col < input; col++)
            {
                Console.Write("{0, 4}", matrixB[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine(new string('-', 25));

        Console.WriteLine("c)");

        int[,] matrixC = new int[input, input];
        int startRow = input - 1;
        int startCol = 0;
        int currentNumber = 1;

        for (int i = 1; i <= input * 2; i++) //fill matrix c)
        {
            currentRow = startRow;
            currentCol = startCol;
            
            while (currentRow <= input - 1 && currentCol <= input - 1)
            {
                matrixC[currentRow, currentCol] = currentNumber;
                currentRow++;
                currentCol++;
                currentNumber++;
            }

            if (startRow > 0)
            {
                startRow--;
            }
            else
            {
                startCol++;
            }
        }
        for (int row = 0; row < input; row++) //print matrix c)
        {
            for (int col = 0; col < input; col++)
            {
                Console.Write("{0, 4}", matrixC[row, col]);
            }
            Console.WriteLine();
        }

        Console.WriteLine(new string('-', 25));
        Console.WriteLine("d)");
        for (int row = 0; row < input; row++) //print matrix d)
        {
            for (int col = 0; col < input; col++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}