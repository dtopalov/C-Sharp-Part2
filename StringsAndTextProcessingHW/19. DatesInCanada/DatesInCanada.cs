//Problem 19. Dates from text in Canada

//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

class DatesInCanada
{
    static void Main()
    {
        Console.WriteLine("Enter text: ");
        string input = Console.ReadLine();
        DateTime date;
        Thread.CurrentThread.CurrentCulture = new CultureInfo("BG");
        var dates = new List<DateTime>();

        for (int i = 0; i < input.Length ; i++)
        {
            if (i < input.Length - 9 && DateTime.TryParse(input.Substring(i, 10), out date))
            {
                dates.Add(date);
            }
        }
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
        for (int i = 0; i < dates.Count; i++)
        {
            Console.WriteLine("{0:d}", dates[i]);
        }
    }
}
