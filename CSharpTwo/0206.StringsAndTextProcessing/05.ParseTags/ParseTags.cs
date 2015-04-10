using System;
using System.Text;
class ParseTags
{
    public static int lenght;
    static void Main()
    {
        string str = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        StringBuilder changedCase = new StringBuilder();
        int index = 0;
        for (index = 0; index < str.Length; index++)
        {
            if (str[index] == '<' && str[index + 1] != '/')
            {
                changedCase.Append(ChangeCase(str, index));
                index += lenght + 16;
            }
            else
            {
                changedCase.Append(str[index]);
            }
        }
        Console.WriteLine(changedCase);
    }

    private static string ChangeCase(string str, int index)
    {
        string upperCase = string.Empty;
        lenght = (str.IndexOf('<', index + 1)) - index - 8;
        
            upperCase = str.Substring((index + 8), lenght).ToUpper();
            return upperCase;
    }
}