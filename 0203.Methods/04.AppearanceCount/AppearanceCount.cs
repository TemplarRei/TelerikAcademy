//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.
using System;
using System.Collections.Generic;
using System.Linq;
class AppearanceCount
{
    static void Main()
    {
        Console.WriteLine("Enter your int array, separated by comas:");
        int[] arr = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 }; /*Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();*/
        Console.Write("Enter the number for searching:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(AppearanceCounter(arr, number));
    }

    private static int AppearanceCounter(int[] arr, int number)
    {
        int counter = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == number)
            {
                counter++;
            }
        }
        return counter;
    }
}