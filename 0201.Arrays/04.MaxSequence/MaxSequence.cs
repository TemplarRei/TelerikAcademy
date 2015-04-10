//Write a program that finds the maximal sequence of equal elements in an array.
//Example:
//input 	                    |result
//2, 1, 1, 2, 3, 3, 2, 2, 2, 1 	|2, 2, 2
using System;
using System.Linq;
class MaxSequence
{
    static void Main()
    {
        Console.WriteLine("Enter an array on a single line:");
        int[] arr = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 }; /*Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();*/
        int counter = 1;
        int recursiveNum = 0;
        int counterFinal = 0;
        int recursiveNumFinal = 0;

        for (int i = 1; i < arr.Length; i++)
        {

            if (arr[i] != arr[i - 1])
            {
                counter = 1;
                recursiveNum = 0;
            }
            if (arr[i - 1] == arr[i])
            {
                counter++;
                recursiveNum = arr[i];

                if (counter > counterFinal)
                {
                    counterFinal = counter;
                    recursiveNumFinal = recursiveNum;
                }
            }
        }
        for (int i = 0; i < counterFinal; i++)
        {
            Console.Write("{0}, ", recursiveNumFinal);
        }
        Console.WriteLine("\b\b \n");
    }
}