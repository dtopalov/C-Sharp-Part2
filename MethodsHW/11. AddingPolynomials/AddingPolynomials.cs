using System;

class AddingPolynomials
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
        Console.WriteLine(" + ");
        PrintPolynomial(secondPolynomialCoef); //print second polynomial
        Console.WriteLine(new string('-', 20));

        int[] sumCoef = AddPolynomials(firstPolynomialCoef, secondPolynomialCoef);

        PrintPolynomial(sumCoef); //print result
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

    static int[] AddPolynomials(int[] firstPolynomial, int[] secondPolynomial)
    {
        int[] result = new int[Math.Max(firstPolynomial.Length, secondPolynomial.Length)];

        for (int i = 0; i < result.Length; i++)
        {
            if (i < Math.Min(firstPolynomial.Length, secondPolynomial.Length))
            {
                result[i] = firstPolynomial[i] + secondPolynomial[i];
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
}