//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
using System;
class DecToHex
{
    static void Main()
    {
        Console.WriteLine("Enter decimal number to be converted:");
        long decNum = long.Parse(Console.ReadLine());
        long division = decNum;
        long temp;
        string hexNum = string.Empty;
        while (division >= 1)
        {
            temp = division % 16;
            switch (temp)
            {
                case 0: hexNum = "0" + hexNum; break;
                case 1: hexNum = "1" + hexNum; break;
                case 2: hexNum = "2" + hexNum; break;
                case 3: hexNum = "3" + hexNum; break;
                case 4: hexNum = "4" + hexNum; break;
                case 5: hexNum = "5" + hexNum; break;
                case 6: hexNum = "6" + hexNum; break;
                case 7: hexNum = "7" + hexNum; break;
                case 8: hexNum = "8" + hexNum; break;
                case 9: hexNum = "9" + hexNum; break;
                case 10: hexNum = "A" + hexNum; break;
                case 11: hexNum = "B" + hexNum; break;
                case 12: hexNum = "C" + hexNum; break;
                case 13: hexNum = "D" + hexNum; break;
                case 14: hexNum = "E" + hexNum; break;
                case 15: hexNum = "F" + hexNum; break;
                default:
                    break;
            }
            division /= 16;
        }
        Console.WriteLine(hexNum);
    }
}