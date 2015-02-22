//Problem 3. Day of week

//Write a program that prints to the console which day of the week is today.

using System;

class DayOfWeek
{
    static void Main()
    {
        DateTime now = DateTime.Now;
        Console.WriteLine("Today is {0}.", now.DayOfWeek);
    }
}
