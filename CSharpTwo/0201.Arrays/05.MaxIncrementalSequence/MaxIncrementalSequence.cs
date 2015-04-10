//Write a program that finds the maximal increasing sequence in an array.
//Example:
//input 	            |result
//3, 2, 3, 4, 2, 2, 4 	|2, 3, 4
using System;
using System.Linq;
class MaxIncrementalSequence
{
    static void Main()
    {
        Console.WriteLine("Enter array on a single line:");
        int[] arr = {3, 2, 3, 4, 2, 2, 4}; /*Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();*/
        int counter = 1;
        int counterFinal = 0;
        int incrementalIndex = 0;
        int incrementalIndexFinal = 0;

        for (int i = 1; i < arr.Length; i++)
        {

            if (arr[i] - 1 != arr[i - 1])
            {
                counter = 1;
                incrementalIndex = 0;
            }
            if (arr[i - 1] + 1 == arr[i])
            {
                counter++;
                incrementalIndex = i;

                if (counter > counterFinal)
                {
                    counterFinal = counter;
                    incrementalIndexFinal = incrementalIndex;
                }
            }
        }
        for (int i = incrementalIndexFinal - counterFinal + 1; i <= incrementalIndexFinal; i++)
        {
            Console.Write("{0}, ", arr[i]);
        }
        Console.WriteLine("\b\b \n");
    }
}