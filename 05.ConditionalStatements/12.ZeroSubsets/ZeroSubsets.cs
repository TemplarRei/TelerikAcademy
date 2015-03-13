//We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
//Assume that repeating the same subset several times is not a problem.
using System;
class ZeroSubsets
{
    static void Main()
    {
        Console.WriteLine("Enter 5 integers separated by space:");
        string[] numInString = Console.ReadLine().Split(' ');
        int[] num = new int[numInString.Length];

        for (int a = 0; a < 5; a++)
        {
            num[a] = Convert.ToInt32(numInString[a]);
        }

        int sum;
        bool subsets = false;

        for (int i = 0; i < 5; i++)
        {
            sum = 0;

            for (int j = i; j < 5; j++)
            {

                sum = sum + num[j];
                if (sum == 0)
                {

                    subsets = true;

                    for (int k = i; k < j; k++)
                    {
                        Console.Write("{0} + ", num[k]);
                    }
                    Console.WriteLine("{0} = 0\n", num[j]);
                }
            }
        }
        if (subsets == false)
        {
            Console.WriteLine("No zero subset\n");
        }
    }
}