//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
using System;
    class SumOfNNums
    {
        static void Main()
        {
            Console.WriteLine("Enter n value for number count:");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Enter integer value above 0:");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter {0} numbers, separated by space for the program to sum.", n);
            string nums = Console.ReadLine();

            double sum = 0;
            string[] stringNums = nums.Split(' ');
            int[] numbers = int.Parse(stringNums[]);
            for (int i = 0; i < n; i++)
            {
                sum += double.Parse(stringNums[i]);
            }
            Console.WriteLine("The sum of the numbers is: {0}", sum);
        }
    }