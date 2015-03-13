//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000
using System;
using System.Numerics;
class TrailingZeroes
{
    static void Main()
    {
        Console.WriteLine("Enter positive integer value of n:");
        int n = int.Parse(Console.ReadLine());
        double factorial = 1;
        double counter = 0;

        while (Math.Pow(5, factorial) <= n)
        {
            counter += n / (int)Math.Pow(5, factorial);
            factorial++;
        }
        Console.WriteLine(counter);
    }
}