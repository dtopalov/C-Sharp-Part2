using System;
using System.Numerics;

class CalcFact
{
    static void Main()
    {
        Console.Write("Enter an integer (1 <= n <= 100): ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("n! = {0}", CalculateFactorial(n));
    }

    static BigInteger CalculateFactorial(int n)
    {
        if (n <= 1)
        {
            return 1;
        }

        return CalculateFactorial(n - 1)*n;
    }
}

