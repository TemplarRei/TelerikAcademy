//Write a program that finds the sequence of maximal sum in given array.
//Example:
//input 	                        |result
//2, 3, -6, -1, 2, -1, 6, 4, -8, 8 	|2, -1, 6, 4
//Can you do it with only one loop (with single scan through the elements of the array)?

using System;
class MaxSum
{
    static void Main()
    {
        //input
        Console.WriteLine("Enter the length N of the array:");
        //int lenghtN = int.Parse(Console.ReadLine());
        int[] arrN = {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}; /*new int[lenghtN];

        Console.WriteLine("Enter the Array indexes:");
        for (int i = 0; i < lenghtN; i++)
        {
            Console.Write("Array[{0}]: ", i);
            arrN[i] = int.Parse(Console.ReadLine());
        }*/

        int currentSum = arrN[0];
        int startIndex = 0;
        int endIndex = 0;
        int temp = 0;
        int maxSum = arrN[0];

        //logic (This counts for a single scan through the elements, yes?)
        for (int i = 1; i < arrN.Length; i++)
        {
            if (currentSum < 0)
            {
                currentSum = arrN[i];
                temp = i;
            }

            else
            {
                currentSum += arrN[i];
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                startIndex = temp;
                endIndex = i;
            }
        }

        //output
        Console.WriteLine("The best sum is: {0} ", maxSum);
        Console.Write("The best sequence is: ");
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write("{0}, ", arrN[i]);
        }
        Console.WriteLine("\b\b \n");
    }
}