    //Write a program that reads a year from the console and checks whether it is a leap one.
    //Use System.DateTime.
using System;
class LeapYear
{
    static void Main()
    {

        Console.WriteLine("Enter a year:");
        int year = int.Parse(Console.ReadLine());
        DateTime years = new DateTime(year, 2, 28 );
        CheckIfLeap(years);
    }

    private static void CheckIfLeap(DateTime years)
    {
        DateTime check = new DateTime(years.Year, 3, 1);
        if (years.AddDays(1) == check)
        {
            Console.WriteLine("The year is not a leap one.");
        }
        else
        {
            Console.WriteLine("The year is a leap year.");
        }
    }

}