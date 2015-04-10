//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
using System;
    class RandNumsInGivenRng
    {
        static void Main()
        {
            Random randGen = new Random();

            Console.WriteLine("Enter values of n, min and max, each on a single line:");
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", randGen.Next(min, max));
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }