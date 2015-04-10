//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
using System;
using System.Collections.Generic;
using System.Linq;
class NFactorial
{
    static void Main()
    {
        Console.WriteLine("Enter a positive integer smaller than 100:");
        int startingNumber = int.Parse(Console.ReadLine());
        RangeCheck(startingNumber);
        List<int> factorial = CalculateFactorial(startingNumber);
        Console.WriteLine(string.Join("", factorial));
    }

    private static void RangeCheck(int startingNumber)
    {
        if (startingNumber > 100 || startingNumber < 1)
        {
            throw new IndexOutOfRangeException
            ("The number must be positive, integer and below 100");
        }
    }

    private static List<int> CalculateFactorial(int startingNumber)
    {
        int[] a = { 1 };

        for (int i = 2; i <= startingNumber; i++)
        {
            int carryOver = 0;
            int[] b = i.ToString().Select(ch => ch - '0').ToArray();
            int[] c = new int[a.Length + b.Length];

            for (int k = a.Length - 1; k >= 0; k--)
            {
                for (int j = b.Length - 1; j >= 0; j--)
                {
                    c[a.Length - k + b.Length - j - 2] += a[k] * b[j];
                }
            }

            for (int j = 0; j < c.Length; j++)
            {
                int digits = c[j] + carryOver;
                c[j] = digits % 10;
                carryOver = digits / 10;
            }
            a = c;
            Array.Reverse(c);
        }

        int startPoint = 0;
        while (a[startPoint] == 0)
        {
            startPoint++;
        }

        List<int> factorial = new List<int>();
        for (int i = startPoint; i < a.Length; i++)
        {
            factorial.Add(a[i]);
        }

        return factorial;
    }
}