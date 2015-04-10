//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.
using System;
class HexToDec
{
    static void Main()
    {

        Console.WriteLine("Enter hexadecimal value of N:");
        string hexNum = Console.ReadLine();


        long decNum = 0;
        long temp = 0;
        for (int i = 1, pow = 0; i <= hexNum.Length; i++, pow++)
        {
            if (long.TryParse(hexNum[hexNum.Length - i].ToString(), out temp))
            {
                temp = long.Parse(hexNum[hexNum.Length - i].ToString());
                decNum += temp * (long)Math.Pow(16, pow);
            }
            else
            {
                switch (hexNum[hexNum.Length - i].ToString())
                {
                    case "A": decNum += 10 * (long)Math.Pow(16, pow); break;
                    case "B": decNum += 11 * (long)Math.Pow(16, pow); break;
                    case "C": decNum += 12 * (long)Math.Pow(16, pow); break;
                    case "D": decNum += 13 * (long)Math.Pow(16, pow); break;
                    case "E": decNum += 14 * (long)Math.Pow(16, pow); break;
                    case "F": decNum += 15 * (long)Math.Pow(16, pow); break;
                    default:
                        break;
                }
            }
        }
        Console.WriteLine(decNum);
    }
}