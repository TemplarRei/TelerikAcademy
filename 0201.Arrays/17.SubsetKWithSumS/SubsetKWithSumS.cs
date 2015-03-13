//Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//Find in the array a subset of K elements that have sum S or indicate about its absence.
using System;
using System.Collections.Generic;
using System.Linq;
class SubsetKWithSumS
{
    static void Main()
    {

        
        Console.WriteLine("Enter enter integers, separated by comas: ");
        int[] numbers = { 2, 1, 2, 4, 3, 5, 2, 6 }; /*Console.ReadLine().Split(new char[] { ' ', ',', '\t', '\r', '\n' },
            StringSplitOptions.RemoveEmptyEntries)
        .Select(x => int.Parse(x))
        .ToArray();*/
        Console.Write("Enter value of the sum: ");
        int sum = 14; //int.Parse(Console.ReadLine());
        int k = 4;
        int offset = Math.Abs(numbers.Where(x => x < 0).Sum());
        int maxSum = numbers.Where(x => x > 0).Sum() + 1;

        bool[] possibleSums = new bool[maxSum + offset];
        List<int>[] stepsCount = new List<int>[maxSum + offset];
        for (int i = 0; i < stepsCount.Length; i++)
        {
            stepsCount[i] = new List<int>();
        }


        possibleSums[offset] = true;
        stepsCount[offset].Add(0);

        foreach (var number in numbers)
        {
            if (number < 0)
            {
                for (int i = 0; i < possibleSums.Length; i++)
                {
                    if (possibleSums[i])
                    {
                        possibleSums[i + number] = true;
                        foreach (var item in stepsCount[i])
                        {
                            stepsCount[i + number].Add(item + 1);
                        }
                    }
                }
            }
            else
            {
                for (int i = possibleSums.Length - 1; i >= 0; i--)
                {
                    if (possibleSums[i])
                    {
                        possibleSums[i + number] = true;
                        foreach (var item in stepsCount[i])
                        {
                            stepsCount[i + number].Add(item + 1);
                        }
                    }
                }
            }
        }

        if (sum + offset < 0 || sum + offset >= maxSum)
        {
            Console.WriteLine(false);
            return;
        }
        Console.WriteLine(stepsCount[sum+offset].Contains(k));

    }
}