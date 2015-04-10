using System;
using System.Collections.Generic;
class Palindromes
{
    static readonly string[] punctuation = new string[] { ".", ",", "!", "-", ":", "?" };
    static void Main()
    {
        Console.WriteLine("Enter some text:");
        string str = "Some text with some palindromes like ABBA, lamal and exe."; //Console.ReadLine();
        string[] tokens = SplitToTokens(str);
        string[] reversedTokens = ReverseStrings(tokens);
        List<string> palindromes = new List<string>();
        for (int i = 0; i < tokens.Length; i++)
        {
            if (tokens[i] == reversedTokens[i])
            {
                palindromes.Add(tokens[i]);
            }
        }
        Console.WriteLine(string.Join("\r\n", palindromes));
    }

    private static string[] ReverseStrings(string[] tokens)
    {
        string[] reversedTokens = new string[tokens.Length];
        for (int i = 0; i < tokens.Length; i++)
			{
            char[] arr = tokens[i].ToCharArray();
            Array.Reverse(arr);
            reversedTokens[i] = new string(arr);
        }
        return reversedTokens;
    }
    private static string[] SplitToTokens(string sentence)
    {
        foreach (var symbol in punctuation)
        {
            sentence = sentence.Replace(symbol, (" "));
        }
        string[] splitSentence = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return splitSentence;
    }
}