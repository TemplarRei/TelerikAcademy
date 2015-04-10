using System;
using System.Collections.Generic;
using System.Linq;
class ForbiddenWords
{
    public static List<string> forbiddenWords = new List<string>() { "PHP", "CLR", "Microsoft" };
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today. Microsoft. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

        string censor = Censor(text);

        Console.WriteLine(censor);
    }

    private static string Censor(string text)
    {
        for (int i = 0; i < forbiddenWords.Count; i++)
        {
            text = text.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
        }
        return text;
    }


}
