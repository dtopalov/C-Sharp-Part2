//Problem 3. Correct brackets

//Write a program to check if in a given expression the brackets are put correctly.

using System;

class CheckBrackets
{
    static void Main()
    {
        Console.WriteLine("Enter an expression with some brackets in it: ");
        string input = Console.ReadLine();
        int leftBrackets = 0;
        int rightBrackets = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                leftBrackets++;
            }
            else if (input[i] == ')')
            {
                rightBrackets++;
            }

            if (rightBrackets > leftBrackets) //if at any point the closing brackets are more than the
            {                                 //opening ones, the expression is incorrect
                break;
            }
        }
        if (leftBrackets == rightBrackets)
        {
            Console.WriteLine("Correct brackets"); //The whole expression could still be incorrect, but this
        }                                          //is beyond the scope of the problem
        else
        {
            Console.WriteLine("Incorrect brackets");
        }
    }
}

