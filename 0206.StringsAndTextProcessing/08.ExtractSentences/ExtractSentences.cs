using System;
using System.Text;
class ExtractSentences
{
    static void Main()
    {
        string str = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string keyWord = "in";
        keyWord = " " + keyWord + " ";
        string extracted = ExtractSentence(str, keyWord);
        Console.WriteLine(extracted);
    }

    private static string ExtractSentence(string str, string keyWord)
    {
        StringBuilder extracted = new StringBuilder();
        int upperIndex = 0;
        int sentenceLenght = 0;
        for (int i = 0; i < str.Length; i++)
        {
            
            if (Char.IsUpper(str[i]))
            {
                upperIndex = i;
                sentenceLenght = str.IndexOf('.', upperIndex) - upperIndex + 1;
            }
            if (i + keyWord.Length < str.Length && str.Substring(i, keyWord.Length) == keyWord)
            {
                extracted.Append(str, upperIndex, sentenceLenght);
                extracted.Append(" ");
                i++;
                upperIndex = 0;
                sentenceLenght = 0;
            }
        }
        return extracted.ToString();
    }
}