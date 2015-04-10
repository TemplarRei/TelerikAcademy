using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
class ExtractTextFromHTML
{
    static void Main()
    {

        StreamReader reader = new StreamReader("..//Периодът за кандидатстване изтече - Телерик Академия - Студентска система.htm");
        string html = reader.ReadToEnd();
        string final = StripHTML(html);
        Console.WriteLine(final);
    }
    public static string StripHTML(string HTMLText)
    {
        Regex reg = new Regex("<[^>]+>", RegexOptions.IgnoreCase);
        return reg.Replace(HTMLText, "");
    }
}