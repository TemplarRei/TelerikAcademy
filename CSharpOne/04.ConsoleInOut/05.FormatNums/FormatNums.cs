/*Write a program that reads 3 numbers:
integer a (0 <= a <= 500)
floating-point b
floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
The number a should be printed in hexadecimal, left aligned
Then the number a should be printed in binary form, padded with zeroes
The number b should be printed with 2 digits after the decimal point, right aligned
The number c should be printed with 3 digits after the decimal point, left aligned.*/
using System;
class FormatNums
{
    static void Main()
    {
        int intA;
        do
        {
            Console.WriteLine("Enter first number (0<=a<=500)");
            intA = int.Parse(Console.ReadLine());
        } while (0 > intA || intA > 500);

        Console.WriteLine("Enter decimal b:");
        float floatB = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter decimal c:");
        float floatC = float.Parse(Console.ReadLine());

        Console.WriteLine("|{0,-10}|{1,-10}|{2,-10}|{3,-10}|", "a", "b", "c", "result");
        Console.WriteLine("|{0,-10}|{1}|{2,10:0.00}|{3,-10:F3}|", intA.ToString("X"), Convert.ToString(intA, 2).PadLeft(10, '0'), floatB, floatC);
    }
}