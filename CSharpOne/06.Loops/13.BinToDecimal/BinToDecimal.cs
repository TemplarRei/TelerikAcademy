//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.
using System;
using System.Linq;
class BinToDecimal
{
    static void Main()
    {

        Console.WriteLine("Enter binary number to be converted to decimal:");
        string binaryNum = Console.ReadLine();
        long decimalNum = 0;

        for (int bitIndex = binaryNum.Length - 1, pow = 0; bitIndex >= 0; bitIndex--, pow++)
        {
            decimalNum += int.Parse(binaryNum[bitIndex].ToString()) * (int)Math.Pow(2, pow);
        }
        Console.WriteLine(decimalNum);
    }
}