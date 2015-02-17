using System;
using System.Data;
using System.Runtime.ExceptionServices;

class Matrix
{
    private int[,] matrix;

    public int Rows
    {
        get
        {
            return this.matrix.GetLength(0);
        }
    }

    public int Cols
    {
        get
        {
            return this.matrix.GetLength(1);
        }
    }

    public Matrix(int rows, int cols)
    {
        this.matrix = new int[rows, cols];
    }

    public int this[int row, int col]
    {
        get { return this.matrix[row, col]; }
        set { this.matrix[row, col] = value; }
    }

    public static Matrix operator + (Matrix matrix1, Matrix matrix2)
    {
        Matrix resultMatrix = new Matrix(matrix1.Rows, matrix1.Cols);
        for (int i = 0; i < matrix1.Rows; i++)
        {
            for (int j = 0; j < matrix1.Cols; j++)
            {
                resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return resultMatrix;
    }

    public static Matrix operator - (Matrix matrix1, Matrix matrix2)
    {
        Matrix resultMatrix = new Matrix(matrix1.Rows, matrix1.Cols);
        for (int i = 0; i < matrix1.Rows; i++)
        {
            for (int j = 0; j < matrix1.Cols; j++)
            {
                resultMatrix[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }
        return resultMatrix;
    }

    public static Matrix operator *(Matrix matrix1, Matrix matrix2)
    {
        Matrix resultMatrix = new Matrix(matrix1.Rows, matrix2.Cols);
        int result = 0;
        for (int i = 0; i < matrix1.Rows; i++)
        {
            for (int j = 0; j < matrix2.Cols; j++)
            {
                for (int k = 0; k < matrix1.Cols; k++)
                {
                    result += matrix1[i, k]*matrix2[k, j];
                }
                resultMatrix[i, j] = result;
                result = 0;
            }
        }
        return resultMatrix;
    }

    public override string ToString()
    {
        string result = "";
        for (int i = 0; i < this.Rows; i++)
        {
            for (int j = 0; j < this.Cols; j++)
            {
                result += this[i, j];
                if (j < this.Cols - 1)
                {
                    result += ", ";
                }
            }
            result += "\r\n";
        }
        return result;
    }
}
