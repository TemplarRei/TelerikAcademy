//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
using System;
    class SumOfFiveNums
    {
        static void Main()
        {
            Console.WriteLine("Enter five numbers, separated by space");
            string nums = Console.ReadLine();

            int sum = 0;
            string[] stringNums = nums.Split(' ');

            for (int i = 0; i < stringNums.Length; i++)
            {
                sum += int.Parse(stringNums[i]);
            }
            Console.WriteLine("The sum of the numbers is: {0}", sum);
        }
    }