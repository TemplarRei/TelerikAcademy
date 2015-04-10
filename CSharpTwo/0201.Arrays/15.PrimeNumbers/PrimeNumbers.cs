//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
using System;
using System.Collections.Generic;
using System.Linq;
    class PrimeNumbers
    {
        static void Main()
        {
            int n = (int)Math.Sqrt(10000000);
            List<bool> primeNums = Enumerable.Repeat(false, 10000000).ToList();;
            for (int i = 2; i < n; i++)
            {
                if (primeNums[i] == false)
                {
                    for (int j = i * i; j < 10000000; j += i)
                    {
                        primeNums[j] = true;
                    }
                }
            }
            for (int i = 2; i < primeNums.Count; i++)
            {
                if (primeNums[i] == false)
                {
                    Console.Write("{0}, ", i);
                }
            }
            Console.WriteLine("\b\b \n");
        }
    }