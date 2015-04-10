//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix 
//like in the examples below. Use two nested loops.
using System;
class MatrixOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter value of N (1 <= N <= 20):");
        int n = int.Parse(Console.ReadLine());
        int num = 1;

        for (int row = 0; row < n; row++)
        {
            for (int column = num; column <= (n + row); column++)
            {
                Console.Write("{0,3}", column);
            }
            num++;
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}