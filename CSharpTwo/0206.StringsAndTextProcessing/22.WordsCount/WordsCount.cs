using System;
using System.Collections.Generic;
class WordsCount
{
    static readonly string[] punctuation = new string[] { ".", ",", "!", "-", ":", "?" };

    static void Main()
    {
        Console.WriteLine("enter some text:");
        string text = "enter some text:enter some text:"; //Console.ReadLine();
        string[] tokens = SplitToTokens(text);
        Dictionary<string, int> words = new Dictionary<string, int>();
        foreach (string word in tokens)
        {
            if (!words.ContainsKey(word))
            {
                words.Add(word, 1);
            }
            else
            {
                words[word] += 1;
            }
        }
        if (words.Count > 0)
        {
            foreach (var word in words)
            {
                Console.WriteLine("[{0}] {1}", word.Key, word.Value);
            }
        }
        else
        {
            Console.WriteLine("You didn't enter words :)!");
        }
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