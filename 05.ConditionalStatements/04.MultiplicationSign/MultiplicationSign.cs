//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.
using System;
class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        double firstNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        double secondNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        double thirdNum = double.Parse(Console.ReadLine());

        double final = firstNum * secondNum * thirdNum;
        if (final < 0)
        {
            Console.WriteLine("-");
        }
        else if (final == 0)
        {
            Console.WriteLine("0");
        }
        else if (final > 0)
        {
            Console.WriteLine("+");
        }
    }
}