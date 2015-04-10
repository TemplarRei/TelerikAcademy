using System;
using System.Globalization;
using System.Threading;
class DateInBG
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("Enter the date in the followin format:");
        Console.WriteLine("dd.mm.yyyy hour:minute:second");
        string date = "31.01.1993 22:59:59"; //Console.ReadLine();
        DateTime dateParsed = DateTime.ParseExact(date, "dd.MM.yyyy HH:mm:ss", null);
        dateParsed = dateParsed.AddHours(6);
        dateParsed = dateParsed.AddMinutes(30);
        Console.WriteLine(dateParsed.ToString("dd.MM.yyyy HH:mm:ss dddd", CultureInfo.GetCultureInfo("BG-bg")));
    }
}
