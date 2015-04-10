using System;
using System.Text;
class BinToHex
{
    static void Main()
    {
        Console.WriteLine("Enter your binary number:");
        string bin = Console.ReadLine().PadLeft(32, '0');
        int startIndex = 0;
        StringBuilder hex = new StringBuilder(8);
        for (int i = 7; i >=0; i--)
        {
            string temp = bin.Substring(startIndex, 4);
            switch (temp)
            {
                case "0000": hex.Append("0"); break;
                case "0001": hex.Append("1"); break;
                case "0010": hex.Append("2"); break;
                case "0011": hex.Append("3"); break;
                case "0100": hex.Append("4"); break;
                case "0101": hex.Append("5"); break;
                case "0110": hex.Append("6"); break;
                case "0111": hex.Append("7"); break;
                case "1000": hex.Append("8"); break;
                case "1001": hex.Append("9"); break;
                case "1010": hex.Append("A"); break;
                case "1011": hex.Append("B"); break;
                case "1100": hex.Append("C"); break;
                case "1101": hex.Append("D"); break;
                case "1110": hex.Append("E"); break;
                case "1111": hex.Append("F"); break;
            }
            startIndex += 4;
        }
        Console.WriteLine(hex.ToString().TrimStart('0'));
    }
}
