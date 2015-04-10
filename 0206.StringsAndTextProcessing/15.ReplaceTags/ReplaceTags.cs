using System;
using System.Text;
class ReplaceTags
{
    static void Main()
    {
        string input = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>"; //Console.ReadLine();
        StringBuilder tagged = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] < input.Length && input[i] == '<' && input[i + 1] == 'a')
            {
                tagged.Append("[URL=");
                i += 8;
            }
            else if (i > 0 && i < input.Length - 2 && input[i-1] != 'p' && input[i] == '"' && input[i + 1] == '>')
            {
                tagged.Append(']');
                i+= 2;
            }
            else if (i < input.Length - 4 && input.Substring(i, 4) == "</a>")
            {
                tagged.Append("[/URL]");
                i += 4;
            }
            {
                tagged.Append(input[i]);
            }
        }
        Console.WriteLine(tagged);
    }
}