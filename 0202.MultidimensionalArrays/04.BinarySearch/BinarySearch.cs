using System;
using System.Collections.Generic;
class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Enter your int array, separated by coma (,):");
        List<int> arr = new List<int> { 1, 3, 7, 12, 13, 23, 45 }; /*Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();*/

        Console.Write("Enter value of K:");
        int K = int.Parse(Console.ReadLine());
        int index = Math.Abs(arr.BinarySearch(K));

        if (arr.BinarySearch(K) > 0)
        {
            Console.WriteLine(arr[index]);
        }
        else
        {
            Console.WriteLine(arr[index - 1]);
        }
    }
}