//Problem 5. Workdays

//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public 
//holidays specified preliminary as array.

using System;
using System.Globalization;
using System.Linq;
using System.Threading;

class Workdays
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter a date (yyyy,MM,dd): ");
        DateTime targetDate = DateTime.Parse(Console.ReadLine()); //yyyy, MM, dd
        Console.WriteLine("There are {0} working days until {1:D}.", CalcWorkdays.CountWorkdays(targetDate), targetDate);
    }

}

static class CalcWorkdays
{
    public static int CountWorkdays(DateTime target)
    {
        DateTime today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        int count = 0;

        while (today != target)
        {
            today = today.AddDays(1); //"moving" today forward and counting the days that are not Saturday, Sunday or predefined holiday
            if (today.DayOfWeek != DayOfWeek.Saturday &&
                today.DayOfWeek != DayOfWeek.Sunday &&
                !today.IsHoliday())
            {
                count++;
            }
        }
        return count;
    }

    public static bool IsHoliday(this DateTime date)
    {
        DateTime[] holidays =   //some holidays are not on a fixed date; add dates according to needs
        {
          new DateTime(date.Year,01,01),
          new DateTime(date.Year,03,03),
          new DateTime(date.Year,05,06),
          new DateTime(date.Year,05,24),
          new DateTime(date.Year,09,06),
          new DateTime(date.Year,09,22),
          new DateTime(date.Year,12,25),
          new DateTime(date.Year,12,26)
        };

        return holidays.Contains(date.Date);
    }
}
