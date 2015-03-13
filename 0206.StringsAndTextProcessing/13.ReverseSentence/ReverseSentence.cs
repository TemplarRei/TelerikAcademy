//Write a program that reverses the words in given sentence.

using System;
using System.Linq;
using System.Text;
class ReverseSentence
{
    static readonly string[] punctuation = new string[] { ".", ",", "!", "-", ":", "?" };
    static void Main()
    {
        Console.WriteLine("Enter a sentence to be reversed: ");
        string text = "C# is not C++, not PHP and not Delphi!"; //Console.ReadLine();

        string[] splitTokens = SplitToTokens(text);
        string[] final = ArrangeWords(text, splitTokens);
        string built = Build(final);
        Console.WriteLine(built);
    }

    private static string Build(string[] final)
    {
        StringBuilder building = new StringBuilder();

        for (int i = 0; i < final.Length; i++)
        {
            if (!punctuation.Contains(final[i]))
            {
                building.Append(" " + final[i]);
            }
            else
            {
                building.Append(final[i]);
            }
        }
        return building.ToString().Trim();
    }

    private static string[] ArrangeWords(string text, string[] splitTokens)
    {
        string[] final = new string[splitTokens.Length];
        for (int index = 0, reverseIndex = splitTokens.Length - index - 1; index < splitTokens.Length; index++)
        {
            if (punctuation.Contains(splitTokens[index].Trim()))
            {
                final[index] = splitTokens[index].Trim();
            }
        }
        for (int index = 0, reverseIndex = splitTokens.Length - index - 1; index < final.Length && reverseIndex >= 0; index++, reverseIndex--)
        {
            while (final[index] != null)
                ++index;
            while (punctuation.Contains(splitTokens[reverseIndex]))
                --reverseIndex;
            final[index] = splitTokens[reverseIndex];
        }

        return final;
    }

    private static string[] SplitToTokens(string sentence)
    {
        foreach (var symbol in punctuation)
        {
            sentence = sentence.Replace(symbol, (" " + symbol + " "));
        }
        string[] splitSentence = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return splitSentence;
    }
}