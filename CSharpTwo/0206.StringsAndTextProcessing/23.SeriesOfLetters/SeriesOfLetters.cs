using System;
class SeriesOfLetters
{
    static void Main()
    {
        Console.WriteLine("Enter a series of letters:");
        string str = "aasaaaaeqeeeqssss"; //Console.ReadLine();

        for (int i = 0; i < str.Length; i++)
        {
            if (i < str.Length - 1 && str[i] == str[i + 1])
            {
                str = str.Remove(i + 1, 1);
                i--;
            }
        }
        Console.WriteLine(str);
    }
}