//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:
//|array| {4, 3, 1, 4, 2, 5, 8}|	S | 11 |result| 4, 2, 5

using System;
using System.Collections.Generic;
using System.Linq;
class FindSumInArray
{
    static void Main()
    {
        //input
        Console.WriteLine("Enter enter integers, separated by comas: ");
        List<int> nums = new List<int> { 4, 3, 1, 4, 2, 5, 8 }; /*Console.ReadLine().Split(new char[] { ' ', ',', '\t', '\r', '\n' },
            StringSplitOptions.RemoveEmptyEntries)
        .Select(x => int.Parse(x))
        .ToList();*/
        List<int> finalSequence = new List<int>();
        Console.Write("Enter value of the sum: ");
        int sum = 11; //int.Parse(Console.ReadLine());
        int tempSum;
        bool subsets = false;

        for (int i = 0; i < 5; i++)
        {
            tempSum = 0;

            for (int j = i; j < nums.Count; j++)
            {

                tempSum = tempSum + nums[j];
                if (tempSum == sum)
                {

                    subsets = true;

                    for (int k = i; k < j; k++)
                    {
                        Console.Write("{0} +", nums[k]);
                    }
                    Console.WriteLine("{0} = {1}\n", nums[j], sum);
                }
            }
        }
        if (subsets == false)
        {
            Console.WriteLine("No subset\n");
        }
    }
}