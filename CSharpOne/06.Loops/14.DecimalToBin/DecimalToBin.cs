//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
using System;
class DecimalToBin
{
    static void Main()
    {
        Console.WriteLine("Enter decimal number to be converted:");
        long decNum = long.Parse(Console.ReadLine());

        string binaryNum = string.Empty;
        long divide = decNum;
        long stringBuilder;

        do
        {
            stringBuilder = divide % 2;
            divide /= 2;
            binaryNum = stringBuilder.ToString() + binaryNum;
        } while (divide != 0);

        Console.WriteLine("Result: {0}", binaryNum.PadLeft(64, '0'));
    }
}