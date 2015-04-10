//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours 
//(when such exist).
using System;
using System.Collections.Generic;
class LargerThanNeightbours
{
    static void Main()
    {

        Console.WriteLine("Enter your int array, separated by comas:");
        int[] arr = { 2, 1, 4, 2, 5, 3, 1, 2, 1, 3 }; /*Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();*/

        Console.Write("Enter the index for searching:");
        int number = int.Parse(Console.ReadLine());
        bool isLarger = LargerCheck(arr, number);
        Console.WriteLine(isLarger);
    }

    private static bool LargerCheck(int[] arr, int number)
    {
        if (number >= arr.Length || number + 1 >= arr.Length || number - 1 < 0)
        {
            return false;
        }
        else
        {
            if (arr[number] > arr[number + 1] && arr[number] > arr[number - 1])
            {
                return true;
            }
        }
        return false;
    }
}