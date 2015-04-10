//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
using System;
using System.Linq;
class RandNumArray
{
    static void Main()
    {
        Random randGen = new Random();

        Console.WriteLine("Enter positive value of n:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = (i + 1);
        }

        for (int i = 1, j = 1; j <= (n * 100) && i <= arr.Length; i++, j++)
        {
            int randomise = randGen.Next(1, arr.Length);
            int mask = arr[randomise];
            arr[randomise] = arr[i - 1];
            arr[i - 1] = mask;
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ", arr[i]);
        }

        Console.WriteLine();
        Console.ReadLine();
    }
}