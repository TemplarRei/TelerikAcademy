using System;
class OrderWords
{
    static void Main()
    {
        Console.WriteLine("Enter a list of words, separated by spaces:");
        string words = "alphabet zebra can queue fish"; //Console.ReadLine();
        string[] splitWords = words.Split(' ');
        Array.Sort(splitWords);
        Console.WriteLine("After split:");
        Console.WriteLine(string.Join(" ", splitWords));
    }
}