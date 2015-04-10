using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Console.WriteLine("enter a text with emails:");
        string text = "qwe@gmail.com sropigha adsoiv acv abv@abv.bg aef@gavu. qwerty@.qwer"; //Console.ReadLine;
        string[] splitText = text.Split(' ');
        List<string> emails = new List<string>();
        for (int i = 0; i < splitText.Length; i++)
        {
            if (splitText[i].Contains("@") && splitText[i].Contains(".") && 
                splitText[i].IndexOf('@') + 1 < splitText[i].IndexOf('.') &&
                splitText[i].IndexOf('.') < splitText[i].Length - 1)
            {
                emails.Add(splitText[i]);
            }
        }
        Console.WriteLine(string.Join("\r\n", emails));
    }
}