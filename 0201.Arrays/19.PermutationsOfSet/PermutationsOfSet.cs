//Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
//Example:
//  N 	    result
//  3 	    {1, 2, 3}
//          {1, 3, 2}
//          {2, 1, 3}
//          {2, 3, 1}
//          {3, 1, 2}
//          {3, 2, 1}
using System;
class PermutationsOfSet
{

    static void Main()
    {
        int n = 3; //int.Parse(Console.ReadLine());
        int[] set = new int[n];
        for (int i = 0; i < set.Length; i++)
        {
            set[i] = i + 1;
        }

        Permutations(set, 0, set.Length - 1);
    }

    private static void Permutations(int[] arr, int index, int lastIndex)
    {
        if (index == lastIndex)
        {
            Console.WriteLine(string.Join(", ", arr));
            return;
        }
        for (int i = index; i < arr.Length; i++)
        {

            Swap(arr, i, index);
            Permutations(arr, index + 1, lastIndex);
            Swap(arr, i, index);
        }
    }

    private static void Swap(int[] arr, int i, int l)
    {
        int temp = arr[i];
        arr[i] = arr[l];
        arr[l] = temp;
    }
}