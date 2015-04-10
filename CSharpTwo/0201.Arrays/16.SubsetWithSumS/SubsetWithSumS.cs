//We are given an array of integers and a number S.
//Write a program to find if there exists a subset of the elements of the array that has a sum S.
//Example:
//input array 	            |S 	|result
//2, 1, 2, 4, 3, 5, 2, 6 	|14	|yes
using System;
using System.Collections.Generic;
using System.Linq;
class SubsetWithSumS
{
    static void Main()
    {

        //input
        Console.WriteLine("Enter enter integers, separated by comas: ");
        int[] numbers = { 2, 1, 2, 4, 3, 5, 2, 6 }; /*Console.ReadLine().Split(new char[] { ' ', ',', '\t', '\r', '\n' },
            StringSplitOptions.RemoveEmptyEntries)
        .Select(x => int.Parse(x))
        .ToArray();*/
        Console.Write("Enter value of the sum: ");
        int sum = 14; //int.Parse(Console.ReadLine());
        int offset = Math.Abs(numbers.Where(x => x < 0).Sum());
        int maxSum = numbers.Where(x => x > 0).Sum() + 1;

        bool[] possibleSums = new bool[maxSum + offset];

        possibleSums[offset] = true;

        foreach (var number in numbers)
        {
            if (number < 0)
            {
                for (int i = 0; i < possibleSums.Length; i++)
                {
                    if (possibleSums[i])
                    {
                        possibleSums[i + number] = true;
                    }
                }
            }
            else
            {
                for (int i = possibleSums.Length-1; i >= 0; i--)
                {
                    if (possibleSums[i])
                    {
                        possibleSums[i + number] = true;
                    }
                }
            }
        }

        if (sum + offset < 0 || sum + offset >= maxSum)
        {
            Console.WriteLine(false);
            return;
        }
        Console.WriteLine(possibleSums[sum+offset]);
    }
}