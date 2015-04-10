using System;
class SubstringInText
{
    static void Main()
    {
        string str = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string subString = "in";
        short counter = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (i + 1 < str.Length && str.Substring(i, subString.Length) == subString)
            {
                counter++;
                i += subString.Length;

            }
        }
        Console.WriteLine(counter);
    }
}