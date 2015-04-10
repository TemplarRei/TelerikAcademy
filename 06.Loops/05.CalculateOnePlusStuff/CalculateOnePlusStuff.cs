//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.
using System;
using System.Numerics;
class CalculateOnePlusStuff
{
    static void Main()
    {

        Console.WriteLine("Enter value for n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for x:");
        int x = int.Parse(Console.ReadLine());
        decimal result = 1;
        decimal factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= Math.Max(i, 1);
            result += factorial / (decimal)Math.Pow(x, i);
        }
        Console.WriteLine("Result: {0:F5}", result);
    }
}