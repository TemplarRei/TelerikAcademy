using System;
using System.Collections.Generic;
class LettersCount
{
    static void Main()
    {
        Console.WriteLine("enter some text:");
        string text = "enter some text:enter some text:"; //Console.ReadLine();
        Dictionary<char, int> letters = new Dictionary<char, int>();
        foreach (char character in text)
        {
            if (Char.IsLetter(character))
            {
                if (!letters.ContainsKey(character))
                {
                    letters.Add(character, 1);
                }
                else
                {
                    letters[character] += 1;
                }
            }
        }
        if (letters.Count > 0)
        {
            foreach (var letter in letters)
            {
                Console.WriteLine("[{0}] {1}", letter.Key, letter.Value);
            }
        }
        else
        {
            Console.WriteLine("You didn't enter letters :)!");
        }
    }
}
