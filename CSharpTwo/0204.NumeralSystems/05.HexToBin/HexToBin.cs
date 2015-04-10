using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class HexToBin
{
    static void Main()
    {
        Console.WriteLine("Enter your hexadecimal number:");
        string hex = Console.ReadLine();
        StringBuilder bin = new StringBuilder();
        for (int i = 0; i < hex.Length; i++)
        {
            switch (hex[i])
            {
                case '0': bin.Append(0000); break;
                case '1': bin.Append(0001); break;
                case '2': bin.Append(0010); break;
                case '3': bin.Append(0011); break;
                case '4': bin.Append(0100); break;
                case '5': bin.Append(0101); break;
                case '6': bin.Append(0110); break;
                case '7': bin.Append(0111); break;
                case '8': bin.Append(1000); break;
                case '9': bin.Append(1001); break;
                case 'A':
                case 'a': bin.Append(1010); break;
                case 'B':
                case 'b': bin.Append(1011); break;
                case 'C':
                case 'c': bin.Append(1100); break;
                case 'D':
                case 'd': bin.Append(1101); break;
                case 'E':
                case 'e': bin.Append(1110); break;
                case 'F':
                case 'f': bin.Append(1111); break;
            }
        }
        Console.WriteLine(bin);
    }
}
