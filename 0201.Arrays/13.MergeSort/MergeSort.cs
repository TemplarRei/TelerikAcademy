//Write a program that sorts an array of integers using the Merge sort algorithm.
using System;
using System.Collections.Generic;
using System.Linq;
class MergeSort
{
    static void Main()
    {
        int[] arr = { 5, 3, 12, 4, 8, 1, 2 }; /*Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();*/ 
        arr = Splitting(arr);
        Console.WriteLine(string.Join(", ", arr));
    }

    private static int[] Splitting(int[] arr)
    {
        if (arr.Length <= 1)
        {
            return arr;
        }
        int middle = arr.Length / 2;
        int[] left = new int[middle];
        int[] right = new int[arr.Length - middle];

        for (int i = 0; i < arr.Length; i++)//We split the array in two.
        {
            if (i < middle)
            {
                left[i] = arr[i];
            }
            else
            {
                right[i - middle] = arr[i];
            }
        }
        left = Splitting(left);
        right = Splitting(right);

        return Merge(left, right);
    }

    private static int[] Merge(int[] left, int[] right)
    {

        int[] result = new int[left.Length + right.Length];
        int i, j;
        for (i = 0, j = 0; i < left.Length && j < right.Length; )
        {

            if (left[i] < right[j])
            {
                result[i + j] = left[i];
                i++;
            }

            else
            {
                result[i + j] = right[j];
                j++;
            }

        }

        for (; i < left.Length;)
        {
            result[i + j] = left[i];
            i++;
        }


        for (; j < right.Length;)
        {
            result[i + j] = right[j];
            j++;
        }
        return result;
    }

}