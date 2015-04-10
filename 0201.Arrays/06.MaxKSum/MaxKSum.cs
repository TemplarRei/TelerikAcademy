//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.
using System;
class MaxKSum
{
    static void Main()
    {
        Console.WriteLine("Enter value of N:");
        int N = int.Parse(Console.ReadLine());
        int[] arrN = new int[N];
        Console.WriteLine("Enter value of K:");
        int K = int.Parse(Console.ReadLine());
        int sum = 0;

        Console.WriteLine("Enter {0} integer values for the array N, each on a separate line:", N);
        for (int i = 0; i < N; i++)
        {
            arrN[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arrN);
        Array.Reverse(arrN);

        Console.Write("The {0} values with maximal sum are:", K);
        for (int i = 0; i < K; i++)
        {
            Console.Write("{0} ", arrN[i]);
            sum += arrN[i];
        }
        Console.WriteLine("\nAnd their sum is: {0}", sum);
    }
}