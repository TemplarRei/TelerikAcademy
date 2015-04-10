//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.
using System;
using System.Numerics;
    class CalculateNKFactorials
    {
        static void Main()
        {

            Console.WriteLine("Enter value of N (1<N<100):");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of K (1<K<N):");
            int k = int.Parse(Console.ReadLine());

            BigInteger result = 1;
            for (int i = (k + 1); i <= n; i++)
			{
                result *= i;
			}
            Console.WriteLine(result);
        }
    }