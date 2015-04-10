//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.
using System;
class MinMaxSumAvgOfNNums
{
    static void Main()
    {
        Console.WriteLine("Enter N (Number of integers to be calculated)");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Enter integer value above 0:");
            n = int.Parse(Console.ReadLine());
        }

        int[] numbers = new int[n];
        Console.WriteLine("Enter {0} integers, each alone in a line:", n);
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int min = int.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            min = Math.Min(numbers[i], min);
        }
        Console.WriteLine("min = {0}", min);

        int max = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            max = Math.Max(numbers[i], max);
        }
        Console.WriteLine("max = {0}", max);

        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine("sum = {0}", sum);

        double avg = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            avg += numbers[i];
        }
        avg /= n;
        Console.WriteLine("avg = {0:0.00}", avg);
        Console.ReadLine();
    }
}