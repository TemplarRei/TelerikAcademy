using System;
class ParseURL
{
    static void Main()
    {
        string url = "http://telerikacademy.com/Courses/Courses/Details/212";

        Uri uri = new Uri(url);
        Console.WriteLine("[protocol] = " + uri.Scheme);
        Console.WriteLine("[server] = " + uri.Host);
        Console.WriteLine("[resource] = " + uri.LocalPath);
    }
}