//Write a program that finds the index of given element in 
//a sorted array of integers by using the Binary search algorithm.
using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an array on a single line:");
            List<int> arr = new List<int> { 1, 3, 7, 12, 13, 23, 45 }; /*Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToList();
            arr.Sort;*/
            Console.WriteLine("Enter key value for searching:");
            int key = int.Parse(Console.ReadLine());
            
            int indexMin = 0;
            int indexMax = arr.Count;
            int keyIndex = 0;
            bool keyFound = false;
            while (indexMin <= indexMax)
            {
                int midPoint = indexMin + ((indexMax - indexMin) / 2);
                if (arr[midPoint] == key)
                {
                    keyIndex = midPoint;
                    keyFound = true;
                    break;
                }
                else if (arr[midPoint] < key)
                {
                    indexMin = midPoint + 1;
                }
                else
                {
                    indexMax = midPoint - 1;
                }
            }
            if (keyFound)
            {
                Console.WriteLine("The key value is at index: " + keyIndex);
            }
            else
            {
                Console.WriteLine("Key not found.");
            }
        }
    }
}
