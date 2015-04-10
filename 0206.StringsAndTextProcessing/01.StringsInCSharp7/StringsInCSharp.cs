using System;
class StringsInCSharp
{
    static void Main()
    {
        //A string in Csharp is a collection of symbols. Some of the more important methods are:
        string empty = string.Empty;
        string formatted = string.Format("{0, 20}", "formatted text");
        int lenght = formatted.Length;
        string[] text = new string[] {"t", "e", "x", "t"};
        string joined = string.Join(string.Empty, text);
        int index = formatted.IndexOf('t');
        string format = formatted.Replace('t', '@');
        string[] split = formatted.Split(new char[] {'t'});
        //Well, I'm not really good with words, so that's that for now :)
    }
}