//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified 
//preliminary as array.
using System;
using System.Collections.Generic;
using System.Globalization;
class Workdays
{
    public static List<DateTime> publicHolidays = new List<DateTime>() 
        {new DateTime(2015, 3, 1),new DateTime(2015, 3, 3),new DateTime(2015, 4, 2),
        new DateTime(2015, 4, 10), new DateTime(2015, 5, 2),new DateTime(2015, 5, 12),
        new DateTime(2015, 5, 16),new DateTime(2015, 6, 13),new DateTime(2015, 6, 15)};
    static void Main()
    {
        Console.WriteLine("Enter the desired date in the format: YYYY.MM.DD ");
        DateTime then = DateTime.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        DateTime now = DateTime.Now;
        int workdays = CountWorkdays(DateTime.Now, then);
        Console.WriteLine("The workdays between {0} and {1} are {2}.", DateTime.Now, then, workdays);

    }

    private static int CountWorkdays(DateTime currentDate, DateTime endDate)
    {
        int workdays = 0;

        while (currentDate <= endDate)
        {
            if (publicHolidays.Contains(currentDate))
            {
                currentDate = currentDate.AddDays(1);
            }
            else if ((int)currentDate.DayOfWeek > 0 && (int)currentDate.DayOfWeek < 6)
            {
                workdays++;
                currentDate = currentDate.AddDays(1);
            }
            else
            {
                currentDate = currentDate.AddDays(1);
            }
        }
        return workdays;
    }
}