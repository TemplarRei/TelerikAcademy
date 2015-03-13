using System;
using System.Globalization;
class DateDifference
{
    static void Main()
    {
        Console.WriteLine("Enter a date in the format dd.MM.yyyy:");
        string one = "01.01.1993";// Console.ReadLine();
        DateTime dateOne = DateTime.ParseExact(one, "dd.MM.yyyy", null);
        Console.WriteLine("Enter a date in the format dd.MM.yyyy:");
        string two = "01.01.1994";//Console.ReadLine();
        DateTime dateTwo = DateTime.ParseExact(two, "dd.MM.yyyy", null);
        TimeSpan elapsed = new TimeSpan(0);
        if (dateTwo > dateOne)
        {
            elapsed = dateTwo - dateOne;
        }
        else
        {
            elapsed = dateOne - dateTwo;
        }
        Console.WriteLine(elapsed.Days + " days");
    }
}