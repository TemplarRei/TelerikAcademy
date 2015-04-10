//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
//Example:
//N 	K 	result
//5 	2 	{1, 2}
//          {1, 3}
//          {1, 4}
//          {1, 5}
//          {2, 3}
//          {2, 4}
//          {2, 5}
//          {3, 4}
//          {3, 5}
//          {4, 5}
using System;
using System.Collections.Generic;
using System.Linq;
class CombinationsOfSet
{
    static void Main()
    {
        int n = 5; //int.Parse(Console.ReadLine());
        int k = 2; //int.Parse(Console.ReadLine());

        
        Combinations(n,new int[k], 0, 1);
    }

    private static void Combinations(int range, int[] arr, int index, int currentNumber)
    {
        if (index == arr.Length)
        {
            Console.WriteLine("{" + string.Join(", ", arr) + "}");
            return;
        }
        for (int i = currentNumber; i <= range; i++)
        {
            arr[index] = i;
            Combinations(range, arr, index + 1, i + 1);
        }
    }
}