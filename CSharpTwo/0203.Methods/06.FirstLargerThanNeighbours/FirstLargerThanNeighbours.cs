//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, 
//if there’s no such element.
//Use the method from the previous exercise.
using System;
class FirstLargerThanNeighbours
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your int array, separated by comas:");
        int[] arr = { 2, 1, 4, 2, 5, 3, 1, 2, 1, 3 }; /*Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();*/

        int firstLarger = LargerCheck(arr);
        Console.WriteLine(firstLarger);
    }
    private static int LargerCheck(int[] arr)
    {

        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1] && arr[i] > arr[i - 1])
            {
                return arr[i];
            }
        }
        return -1;
    }
}