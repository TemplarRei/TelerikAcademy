//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
using System;
using System.Collections.Generic;
using System.Linq;
class GetLargestNumber
{
    static void Main()
    {
        Console.WriteLine("Enter 3 integers, each on a single line:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int greater = GetMax(a, b);
        int max = GetMax(greater, c);
        Console.WriteLine(max);
        
    }

    private static int GetMax(int a, int b)
    {
        if (a> b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}