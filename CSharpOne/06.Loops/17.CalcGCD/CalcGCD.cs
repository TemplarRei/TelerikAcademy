//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).
using System;
class CalcGCD
{
    static void Main()
    {
        Console.WriteLine("Enter value of a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of b:");
        int b = int.Parse(Console.ReadLine());
        int temp;
        bool GDC = false;
        if (a < 0)
        {
            a *= -1;
        }
        if (b < 0)
        {
            b *= -1;
        }
        while (GDC == false)
        {
            if (a < b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            else
            {
                temp = a % b;
                if (temp == 0)
                {
                    GDC = true;
                }
                a = b;
                b = temp;
            }
        }
        Console.WriteLine(a);
    }
}