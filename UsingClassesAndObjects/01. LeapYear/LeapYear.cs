//Problem 1. Leap year

//Write a program that reads a year from the console and checks whether it is a leap one.

using System;

class LeapYear
{
    static void Main()
    {
        Console.WriteLine("Enter positive integer for year: ");
        int year = int.Parse(Console.ReadLine());
        bool isLeap = DateTime.IsLeapYear(year);
        Console.WriteLine("Is {0} a leap year? {1}", year, isLeap?"Yes":"No");
    }
}
