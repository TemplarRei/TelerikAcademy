using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class BinToDec
{
    static void Main()
    {
        Console.WriteLine("Enter your number in binary:");
        string bin = Console.ReadLine();
        sbyte pow = 0;
        int numberAsDec = 0;
        for (int i = bin.Length - 1; i >= 0; i--)
        {
            int temp = (int)Char.GetNumericValue(bin[i]);
            numberAsDec += temp * (int)Math.Pow(2, pow);
            pow++;
        }
        Console.WriteLine(numberAsDec);
    }
}