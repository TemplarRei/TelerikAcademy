//Write a program that reads an array of integers and removes from it a minimal number of elements in such a way that the remaining array is sorted in increasing order.
//Print the remaining sorted array.
//Example:
//input 	                    result
//6, 1, 4, 3, 0, 3, 6, 4, 5 	1, 3, 3, 4, 5
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class RemoveElementsFromArray
{
    static List<int>[] listOfBestSubsets = new List<int>[40];
    static int index = 0;
    static void Main()
    {
        // Console.WriteLine("Enter an array on a single line:");
        int[] arr = { 6, 1, 4, 3, 0, 3, 6, 4, 5 }; /*Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();*/
        FindSubsetsForSum(arr);
        PrintingSubsets(arr);

    }
    static void PrintingSubsets(int[] arr)
    {
        Console.WriteLine("Starting Array: " + string.Join(", ", arr));
        Console.WriteLine("Longest subset(s) with increasing elements: ");
        for (int i = 0; i < index; i++) Console.WriteLine(string.Join(", ", listOfBestSubsets[i]));
    }
    static void FindSubsetsForSum (int[] arr) //Bitwise code I don't fully understand, but works :D
    {
        List<int> subset = new List<int>();
        long bestLength = 0;
        long totalSubsets = (long)(Math.Pow(2, arr.Length) - 1);
        for (long i = totalSubsets; i >= 1; i--)
        {
            long elementInSubset = SubsetElements(i);
            if (elementInSubset < bestLength) continue;
            subset.Clear();
            subset.AddRange(arr.Where((t, j) => ((i >> j) & 1) == 1));
            if (IsIncreasing(subset))
            {
                if (bestLength < elementInSubset)
                {
                    listOfBestSubsets = new List<int>[40];
                    index = 0;
                }
                bestLength = elementInSubset;
                listOfBestSubsets[index++] = new List<int>(subset);
            }
        }
    }
    static long SubsetElements(long currentNum) //More bitwise code I don't fully understand, but works :D (optimization)
    {
        long elementsInSubset = 0;
        while (currentNum != 0)
        {
            elementsInSubset += currentNum & 1;
            currentNum >>= 1;
        }
        return elementsInSubset;
    }
    static bool IsIncreasing(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count - 1; i++)
            if (numbers[i] > numbers[i + 1])
                return false;
        return true;
    }
}
