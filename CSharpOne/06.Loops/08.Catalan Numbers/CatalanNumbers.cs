//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
using System;
    class CatalanNumbers
    {
        static void Main()
        {

            Console.WriteLine("Enter value of N (0 <= N <= 100):");
            int n = int.Parse(Console.ReadLine());

            double result;
            double factorialFirstHalf = 1;
            double factorialSecondHalf = 1;
            //The simple maths are: (2n)!/(n+1)!*n! == 1/(n+1)! * (2n)!/n!

            for (int i = 1; i <= (n + 1); i++)
            {
                factorialFirstHalf *= i;
            }

            for (int i = (n + 1); i <= (2 * n); i++)
            {
                factorialSecondHalf *= i;
            }

            double finalFactorialFirstHalf = 1 / factorialFirstHalf;
            result = finalFactorialFirstHalf * factorialSecondHalf;
            Console.WriteLine("{0:F0}", result);
            Console.ReadLine();
        }
    }