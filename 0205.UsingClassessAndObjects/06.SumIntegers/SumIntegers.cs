//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.
//Example:
//input 	        output
//"43 68 9 23 318" 	461
using System;
using System.Linq;
class SumIntegers
{
    static void Main()
    {
        Console.WriteLine("enter your string of integers, separated by spaces:");
        int[] arr = Console.ReadLine()
            .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();
        long sum = 0;
        foreach (int number in arr)
        {
            sum += number;
        }
        Console.WriteLine(sum);
    }
}