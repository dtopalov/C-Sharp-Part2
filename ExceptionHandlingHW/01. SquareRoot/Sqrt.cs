//Problem 1. Square root

using System;

class Sqrt
{
    static void Main()
    {
        Console.Write("Enter non-negative integer: ");
        try
        {
            int input = int.Parse(Console.ReadLine());
            if (input < 0)
            {
                throw new ArgumentException();
            }
            Console.WriteLine("Square root of {0} = {1}", input, Math.Sqrt(input));
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid input");
        }
        catch (FormatException) //an int can not be parsed from the input
        {
            Console.WriteLine("Invalid input");
        }
        catch (OverflowException) //input number is out of the Int32 range
        {
            Console.WriteLine("Invalid input");
        }
        finally
        {
            Console.WriteLine("Goodbye!");
        }
    }
}
