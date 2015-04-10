using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;

class DatesFromTextInCanada
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string text = "qrethgaiv 12.01.1993 qwertyy 31.12.2911 qwe 1997.01.01"; //Console.ReadLine();
        string[] splitText = text.Split(' ');
        List<DateTime> dates = new List<DateTime>();
        DateTime temp;
        for (int i = 0; i < splitText.Length; i++)
			{
                if (DateTime.TryParseExact(splitText[i], "dd.mm.yyyy", CultureInfo.GetCultureInfo("BG-bg"), DateTimeStyles.None, out temp))
                {
                    dates.Add(temp);
                }
			}
        for (int i = 0; i < dates.Count; i++)
        {
            Console.WriteLine(dates[i].ToString(CultureInfo.GetCultureInfo("en-CA")));
        }

    }
}