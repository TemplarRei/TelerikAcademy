using System;
using System.Text;
class HexToDec
{
    static void Main()
    {

        Console.WriteLine("Enter your number in hex:");
        string hex = Console.ReadLine();
        int pow = 0;
        int numberAsDec = 0;
        int temp;
        for (int i = hex.Length - 1; i >= 0; i--)
        {
            switch (hex[i])
            {
                case 'A':
                case 'a': temp = 10; break;
                case 'B':
                case 'b': temp = 11; break;
                case 'C':
                case 'c': temp = 12; break;
                case 'D':
                case 'd': temp = 13; break;
                case 'E':
                case 'e': temp = 14; break;
                case 'F':
                case 'f': temp = 15; break;
                default: temp = (int)Char.GetNumericValue(hex[i]);
                    break;
            }
            numberAsDec += temp * (int)Math.Pow(16, pow);
            pow++;
        }
        Console.WriteLine(numberAsDec);
    }
}
