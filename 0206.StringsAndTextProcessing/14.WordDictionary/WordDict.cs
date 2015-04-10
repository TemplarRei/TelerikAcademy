using System;
using System.Linq;
class WordDict
{
    public static string[,] dictionary = new string[,] 
    {{".NET", "CLR", "namespace"}, 
    {"platform for applications from Microsoft", "managed execution environment for .NET", "hierarchical organization of classes"}};
    static void Main()
    {
        Console.WriteLine("Enter a word for translation:");
        string word = "namespace"; //Console.ReadLine();
        int indexOfWord = 0;
        for (int i = 0; i < dictionary.GetLength(0); i++)
        {
            if (dictionary[0, i] == word)
            {
                indexOfWord = i;

            }
        }
        Console.WriteLine(word + " translates to: " + dictionary[1, indexOfWord]);
    }
}