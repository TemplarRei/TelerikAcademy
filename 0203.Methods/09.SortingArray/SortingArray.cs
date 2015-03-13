//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.
using System;
using System.Collections.Generic;
using System.Linq;
class SortingArray
{
    static void Main()
    {
        Console.WriteLine("Enter your int array, separated by comas:");
        int[] arr = { 7, 107, 1, 2, 132, 5, 2, 9, 0, 2, 9, 3, 5, 1 }; /*Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray().;*/
        Console.WriteLine("Ascending sort:");
        int[] sortedAscArr = SortAscending(arr);
        Console.WriteLine(string.Join(", ", sortedAscArr));
        Console.WriteLine("Descending sort:");
        int[] sortedDescArr = SortDescending(arr);
        Console.WriteLine(string.Join(", ", sortedDescArr));
    }

    private static int ReturnLargest(int[] arr, int startPoint, int endPoint, int swap)
    {
        int largest = 0;
        int largestIndex = startPoint;
        for (int i = startPoint; i <= endPoint; i++)
        {
            if (arr[i] >= largest)
            {
                largest = arr[i];
                largestIndex = i;
            }
        }

        int temp = arr[swap];
        arr[swap] = arr[largestIndex];
        arr[largestIndex] = temp;

        return arr[swap];
    }

    private static int[] SortAscending(int[] arr)
    {

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            arr[i] = ReturnLargest(arr, 0, i, i);
        }

        return arr;
    }
    private static int[] SortDescending(int[] arr)
    {

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = ReturnLargest(arr, i, arr.Length - 1, i);
        }

        return arr;
    }
}