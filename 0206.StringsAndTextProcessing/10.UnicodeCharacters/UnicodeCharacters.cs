using System;
class UnicodeCharacters
{
    static void Main()
    {
        Console.WriteLine("Enter some text:");
        string text = "some text!"; //Console.ReadLine();
        string[] unicode = new string[text.Length];
        for (int i = 0; i < text.Length; i++)
        {
            int character = (int)text[i];
            unicode[i] = @"\u" + character.ToString("X").PadLeft(4, '0');
        }
        Console.WriteLine(string.Join("", unicode));
    }
}
