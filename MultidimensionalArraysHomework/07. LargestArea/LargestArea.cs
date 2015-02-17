//Problem 7.* Largest area in matrix

//Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.

using System;
using System.Collections.Generic;
using System.Linq;

class LargestArea
{
    static List<int[]> currentPath = new List<int[]>();
    static List<int[]> longestPath = new List<int[]>();
    static int[] last = {-1, -1};
    static bool[,] visited = new bool[5,6]; //same dimensions as the matrix
     
    static void Main()
    {       
        int bestSequence = 0;
        int[,] matrix =
        {
            {1, 3, 2, 2, 2, 4},
            {3, 3, 3, 2, 4, 4},
            {4, 3, 1, 2, 3, 3},
            {4, 3, 1, 3, 3, 1},
            {4, 3, 3, 3, 1, 1}
        };

        for (int i = 0; i < matrix.GetLength(0); i++) //traverse the matrix and invoke the FindPath method for every
        {                                             //unprocessed cell
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (visited[i, j] == false) //current cell isn't marked as visited yet
                {
                    if (currentPath.Count > bestSequence)
                    {
                        bestSequence = currentPath.Count;
                        longestPath = new List<int[]>(); //clear old longest Path and add the new longest path
                        longestPath.AddRange(currentPath);
                    }
                    currentPath = new List<int[]>(); //reset current path
                    FindPath(matrix, i, j);
                }
            }
        }
        Console.WriteLine("The largest area of equal neighbour elements is {0}: ", longestPath.Count);

        for (int i = 0; i < matrix.GetLength(0); i++) //print map of the longest path
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < longestPath.Count; k++)
                {
                    if (longestPath[k][0] == i && longestPath[k][1] == j)
                    {
                        Console.Write("*");
                        break;
                    }

                    if (k == longestPath.Count - 1)
                    {
                        Console.Write(".");    
                    }
                }
            }
            Console.WriteLine();
        }
    }

    static void FindPath(int[,] matrix, int i, int j)
    {
        int[] coordinates = {i, j}; //coordinates of the current and neighbour cells
        int[] aboveCell = {i - 1, j};
        int[] belowCell = { i + 1, j };
        int[] leftCell = { i, j - 1};
        int[] rightCell = { i, j + 1};
        
        bool isInPath = false; //check if the current cell is added to the current path, if not - add it
        for (int k = 0; k < currentPath.Count; k++)
        {
            if (currentPath[k][0] == coordinates[0] && currentPath[k][1] == coordinates[1])
            {
                isInPath = true;
            }
        }
        if (!isInPath)
        {
            currentPath.Add(coordinates);
        }
        //check whether we can visit the neighbour cells
        bool above = (i > 0) && (matrix[i - 1, j] == matrix[i, j]) && (visited[i - 1, j] == false);
        bool left = (j > 0) && (matrix[i, j - 1] == matrix[i, j]) && (visited[i, j - 1] == false);
        bool right = (j < matrix.GetLength(1) - 1) && (matrix[i, j + 1] == matrix[i, j]) && (visited[i, j + 1] == false);
        bool below = (i < matrix.GetLength(0) - 1) && (matrix[i + 1, j] == matrix[i, j]) && (visited[i + 1, j] == false);

        bool[] directions = {above, left, right, below};
        int possibleDirections = directions.Where(x => x).Count(); //count possible directions we can go to

        //make sure we go back to the last visited cell only if we had explored all other options
        if (possibleDirections > 1)
        {
            if (above && (aboveCell[0] != last[0] || aboveCell[1] != last[1]))
            {
                last = coordinates;
                FindPath(matrix, i - 1, j);
            }
            if (left && (leftCell[0] != last[0] || leftCell[1] != last[1]))
            {
                last = coordinates;
                FindPath(matrix, i, j - 1);
            }
            if (below && (belowCell[0] != last[0] || belowCell[1] != last[1]))
            {
                last = coordinates;
                FindPath(matrix, i + 1, j);
            }
            if (right && (rightCell[0] != last[0] || rightCell[1] != last[1]))
            {
                last = coordinates;
                FindPath(matrix, i, j + 1);
            }
        }
        else //this is the last available option to continue, if none of the conditions is met,
             //this is the end of the current path, the method finishes and the program continues
        {
            visited[i, j] = true;
            if (above)
            {
                last = coordinates;
                FindPath(matrix, i - 1, j);
            }
            if (left)
            {
                last = coordinates;
                FindPath(matrix, i, j - 1);
            }
            if (below)
            {
                last = coordinates;
                FindPath(matrix, i + 1, j);
            }
            if (right)
            {
                last = coordinates;
                FindPath(matrix, i, j + 1);
            }
        }
    }
}