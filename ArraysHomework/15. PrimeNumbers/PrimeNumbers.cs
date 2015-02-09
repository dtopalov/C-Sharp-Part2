//Problem 15. Prime numbers

//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;

class PrimeNumbers
{
    static void Main()
    {
        int n = 10000000; //set top of the range to search for prime numbers in
        bool[] sieve = new bool[n]; //indeces are numbers in the range [0, n], all elements are False by default
        for (int i = 2; i < n; i++)
        {
            sieve[i] = true; //set all elements at indeces >= 2 to true
        }
        //set the non-primes back to false by finding their multiples 
        for (int j = 2; j < n; j++)
        {
            if (sieve[j])
            {
                for (int k = 2; (k * j) < n; k++)
                {
                    sieve[k * j] = false;
                }
            }
        }
        //all indeces, such that sieve[index] = true are prime numbers
        //prints all prime numbers to the console (takes a while)
        for (int i = 0; i < sieve.Length; i++)
        {
            if (sieve[i])
            {
                Console.Write(i);
            }
            if (sieve[i] && i < sieve.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}