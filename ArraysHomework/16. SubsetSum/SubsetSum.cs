//Problem 16.* Subset with sum S

//We are given an array of integers and a number S.
//Write a program to find if there exists a subset of the elements of the array that has a sum S.

using System;


class SubsetSum
{
    static void Main(string[] args)
    {
        Console.Write("Enter a sum to look for: ");
        long S = long.Parse(Console.ReadLine());
        long[] input = {2, 1, 2, 4, 3, 5, 2, 6};    //remove this line if you want to enter another input

        //string input = Console.ReadLine();        //uncomment these lines to enter another array in format x, y, ...
        //string[] numsStr = input.Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);
        //long[] inputArr = new long[numsStr.Length];
        //for (int i = 0; i < input.Length; i++)
        //{
        //    inputArr[i] = int.Parse(numsStr[i]);
        //}

        long curSum = 0;
        int count = 0;

        for (int i = 1; i <= (int)Math.Pow(2, input.Length) - 1; i++)
        {
            curSum = 0;
            string template = Convert.ToString(i, 2).PadLeft(input.Length, '0');

            for (int j = 0; j < template.Length; j++)
            {
                if (template[j].ToString() == "1")
                {
                    curSum += input[j];
                }
            }
            if (curSum == S)
            {
                count++;
            }
        }
        if (count > 0)
        {
            Console.WriteLine("Yes, {0} combinations of elements in the array [{1}] have a sum of {2}.", count, string.Join(", ", input), S);
        }
    }
}
