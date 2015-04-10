using System;
//Create a console application that prints the current date and time. Find out how in Internet.
class PrintTimeAndDate
{
    static void Main()
    {
        //We first use the DateTime struct to figure out the current time and date,
        //and then print it in the console with the correct format with the second and third lines.
        //More info here: http://bit.ly/14pcBmo (MSDN)
        DateTime now = DateTime.Now;
        String format = "d/MM/yyyy h:mm";
        Console.WriteLine(now.ToString(format));
    }
}