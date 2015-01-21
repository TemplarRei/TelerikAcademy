//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001
using System;
class ComparingFloats
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        //The trick, I learnt is to look for the abs value of a-b and then compare that with the desired precision.
        bool equal = Math.Abs(a - b) < 0.000001;
        Console.WriteLine(equal);
    }
}