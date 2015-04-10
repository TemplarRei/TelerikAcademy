using System;
using System.Text;
class BinaryFloatingPoint
{
    static void Main()
    {
        Console.WriteLine("Enter your decimal number:");
        float number = float.Parse(Console.ReadLine());

        StringBuilder bin = new StringBuilder();
        byte[] bytes = BitConverter.GetBytes(number);
        Array.Reverse(bytes);
        string stringBytes = BitConverter.ToString(bytes);

        foreach (var hex in stringBytes)
        {
            if (Char.IsDigit(hex) || char.IsLetter(hex))
            {
                switch (hex)
                {
                    case '0': bin.Append("0000".PadLeft(4, '0')); continue;
                    case '1': bin.Append("0001".PadLeft(4, '0')); continue;
                    case '2': bin.Append("0010".PadLeft(4, '0')); continue;
                    case '3': bin.Append("0011".PadLeft(4, '0')); continue;
                    case '4': bin.Append("0100".PadLeft(4, '0')); continue;
                    case '5': bin.Append("0101".PadLeft(4, '0')); continue;
                    case '6': bin.Append("0110".PadLeft(4, '0')); continue;
                    case '7': bin.Append("0111".PadLeft(4, '0')); continue;
                    case '8': bin.Append("1000".PadLeft(4, '0')); continue;
                    case '9': bin.Append("1001".PadLeft(4, '0')); continue;
                    case 'A':
                    case 'a': bin.Append("1010".PadLeft(4, '0')); continue;
                    case 'B':
                    case 'b': bin.Append("1011".PadLeft(4, '0')); continue;
                    case 'C':
                    case 'c': bin.Append("1100".PadLeft(4, '0')); continue;
                    case 'D':
                    case 'd': bin.Append("1101".PadLeft(4, '0')); continue;
                    case 'E':
                    case 'e': bin.Append("1110".PadLeft(4, '0')); continue;
                    case 'F':
                    case 'f': bin.Append("1111".PadLeft(4, '0')); continue;
                }
            }

        }
        string[] result = new string[3];
        result[0] = bin[0].ToString();
        result[1] = bin.ToString().Substring(1, 8);
        result[2] = bin.ToString().Substring(9);
        Console.Write("Sign: {0} ", result[0]);
        Console.Write("Exponent: {0} ", result[1]);
        Console.Write("Mantissa: {0}\n", result[2]);
    }
}