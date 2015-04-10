//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], 
//each on a single line.
using System;
    class NumsFromOneToN
    {
        static void Main()
        {
            System.Console.WriteLine("Enter integer value of n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
			{
			 System.Console.WriteLine(i);
			}
        }
    }