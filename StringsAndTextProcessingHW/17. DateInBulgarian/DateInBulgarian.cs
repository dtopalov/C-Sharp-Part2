//Problem 17. Date in Bulgarian

//Write a program that reads a date and time given in the format: 
//day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes 
//(in the same format) along with the day of week in Bulgarian.

using System;
using System.Globalization;
using System.Text;
using System.Threading;

class DateInBulgarian
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Thread.CurrentThread.CurrentCulture = new CultureInfo("BG");
        Console.WriteLine("Enter date and time in the format day.month.year hour:minute:second(ex: 21.2.2015 12:15:45): ");
        DateTime inputDate = DateTime.Parse(Console.ReadLine());

        inputDate = inputDate.AddHours(6).AddMinutes(30); //adding 6:30 hours to input time

        Console.WriteLine("6:30 часа по-късно: {0}, {1}", 
            DateTimeFormatInfo.CurrentInfo.GetDayName(inputDate.DayOfWeek), inputDate); //printing result in BG
    }
}
