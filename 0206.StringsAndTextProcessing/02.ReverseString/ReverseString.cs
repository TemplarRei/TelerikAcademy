using System;
class ReverseString
{
    static void Main()
    {
        string str = "qwerty"; //Console.ReadLine();
        string reverse = string.Empty;
        for (int i = str.Length - 1; i >= 0; i--)
        {
            reverse += str[i];
        }
        Console.WriteLine(reverse);
    }
}