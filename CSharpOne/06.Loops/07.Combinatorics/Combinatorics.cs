//In combinatorics, the number of ways to choose k different members out of a group of n different elements 
//(also known as the number of combinations) is calculated by the following formula: formula For example, 
//there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
//Try to use only two loops.
using System;
using System.Numerics;
class Combinatorics
{
    static void Main()
    {

        Console.WriteLine("Enter value of N (1<N<100):");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of K (1<K<N):");
        int k = int.Parse(Console.ReadLine());

        double result;
        double factorialFirstHalf = 1;
        double factorialSecondHalf = 1;
        //The simple maths are: n! / (k! * (n-k)!) == n!/k! * 1/(n-k)!
        for (int i = (k + 1); i <= n; i++)
        {
            factorialFirstHalf *= i;
        }

        for (int i = 1; i <= (n-k); i++)
        {
            factorialSecondHalf *= i;
        }
        double finalFactorialSecondHalf = 1 / factorialSecondHalf;
        result = factorialFirstHalf * finalFactorialSecondHalf;
        Console.WriteLine("{0:F0}", result);
        Console.ReadLine();
    }
}