//Problem 6.* Matrix class

//Write a class Matrix, to hold a matrix of integers. Overload the operators for adding, 
//subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().

using System;

class MatrixClass
{
    static void Main()
    {
        Matrix matrix1 = new Matrix(2, 2);
        matrix1[0, 0] = 5;
        matrix1[0, 1] = 2;
        matrix1[1, 0] = 3;
        matrix1[1, 1] = 4;

        Matrix matrix2 = new Matrix(2, 2);
        matrix2[0, 0] = 4;
        matrix2[0, 1] = 3;
        matrix2[1, 0] = 2;
        matrix2[1, 1] = 5;

        Matrix resultSum = matrix1 + matrix2;
        Matrix resultDifference = matrix1 - matrix2;

        Matrix matrix3 = new Matrix(3, 2);
        Matrix matrix4 = new Matrix(2, 4);

        Matrix resultProduct = matrix3*matrix4;

        Console.WriteLine(resultSum);
        Console.WriteLine(resultDifference);
        Console.WriteLine(resultProduct);
    }
}
