//Problem 12. Subtracting polynomials

//Extend the previous program to support also subtraction and multiplication of polynomials.

using System;
using System.Collections.Generic;
using System.Linq;

class SubtractAndMultiplyPolynomials
{
    static void Main()
    {

        Console.WriteLine("Enter the highest degree(^) of x for the first polynomial: ");
        int firstDegree = int.Parse(Console.ReadLine());
        int[] firstPolynomialCoef = new int[firstDegree + 1];

        for (int i = 0; i < firstPolynomialCoef.Length; i++)
        {
            Console.Write("Enter coefficient for x^{0}: ", i);
            firstPolynomialCoef[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the highest degree(^) of x for the second polynomial: ");
        int secondDegree = int.Parse(Console.ReadLine());
        int[] secondPolynomialCoef = new int[secondDegree + 1];

        for (int i = 0; i < secondPolynomialCoef.Length; i++)
        {
            Console.Write("Enter coefficient for x^{0}: ", i);
            secondPolynomialCoef[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        PrintPolynomial(firstPolynomialCoef); //print first polynomial
        Console.WriteLine(" - ");
        PrintPolynomial(secondPolynomialCoef); //print second polynomial
        Console.WriteLine(new string('-', 20));

        int[] subtrCoef = SubtractPolynomials(firstPolynomialCoef, secondPolynomialCoef);
        PrintPolynomial(subtrCoef); //print result

        Console.WriteLine();
        Console.WriteLine();
        PrintPolynomial(firstPolynomialCoef); //print first polynomial
        Console.WriteLine(" * ");
        PrintPolynomial(secondPolynomialCoef); //print second polynomial
        Console.WriteLine(new string('-', 20));

        List<int> multiplicationCoef = MultiplyPolynomials(firstPolynomialCoef, secondPolynomialCoef);
        PrintPolynomial(multiplicationCoef); //print result
    }

    static void PrintPolynomial(int[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] == 0)
            {
                continue;
            }
            if (i >= 0 && array[i] > 0 && i < array.Length - 1)
            {
                Console.Write("+ ");
            }
            if (i > 1)
            {
                if (array[i] == 1 || array[i] == -1)
                {
                    Console.Write("x^" + i + " ");
                }
                else
                {
                    Console.Write(array[i] + "x^" + i + " ");
                }
            }
            else if (i == 1)
            {
                if (array[i] == 1 || array[i] == -1)
                {
                    Console.Write("x ");
                }
                else
                {
                    Console.Write(array[i] + "x ");
                }
            }
            else if (i == 0)
            {
                Console.WriteLine(array[i]);
            }
        }
    }

    static void PrintPolynomial(List<int> list)
    {
        for (int i = list.Count - 1; i >= 0; i--)
        {
            if (list[i] == 0)
            {
                continue;
            }
            if (i >= 0 && list[i] > 0 && i < list.Count - 2)
            {
                Console.Write("+ ");
            }
            if (i > 1)
            {
                if (list[i] == 1 || list[i] == -1)
                {
                    Console.Write("x^" + i + " ");
                }
                else
                {
                    Console.Write(list[i] + "x^" + i + " ");    
                }
            }
            else if (i == 1)
            {
                if (list[i] == 1 || list[i] == -1)
                {
                    Console.Write("x ");
                }
                else
                {
                    Console.Write(list[i] + "x ");
                } 
            }
            else if (i == 0)
            {
                Console.WriteLine(list[i]);
            }
        }
    }

    static int[] SubtractPolynomials(int[] firstPolynomial, int[] secondPolynomial)
    {
        int[] result = new int[Math.Max(firstPolynomial.Length, secondPolynomial.Length)];

        for (int i = 0; i < result.Length; i++)
        {
            if (i < Math.Min(firstPolynomial.Length, secondPolynomial.Length))
            {
                result[i] = firstPolynomial[i] - secondPolynomial[i];
            }
            else
            {
                if (firstPolynomial.Length > secondPolynomial.Length)
                {
                    result[i] = firstPolynomial[i];
                }
                else
                {
                    result[i] = secondPolynomial[i];
                }
            }
        }
        return result;
    }

    static List<int> MultiplyPolynomials(int[] firstPolynomial, int[] secondPolynomial)
    {
        List<int> result = new int[firstPolynomial.Length + secondPolynomial.Length].ToList();


        for (int i = 0; i < firstPolynomial.Length; i++)
        {
            for (int j = 0; j < secondPolynomial.Length; j++)
            {
                result[i + j] += firstPolynomial[i] * secondPolynomial[j];
            }
        }
        return result.SkipWhile(x => x == 0).ToList();
    }
}
