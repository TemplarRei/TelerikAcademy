//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the 
//smallest from the rest, move it at the second position, etc.
using System;
class SelectionSort
{
    static void Main()
    {

        Console.WriteLine("Enter size N of the array:");
        int N = int.Parse(Console.ReadLine());
        int[] arrN = new int[N];

        Console.WriteLine("Enter integer values to fill the array, each on a separate line:");

        for (int i = 0; i < N; i++)
        {
            arrN[i] = int.Parse(Console.ReadLine());
        }

        for (int l = 0; l < arrN.Length; l++)
        {
            int minValue = int.MaxValue;
            int maxValueIndicator = 0;
            int i = 0 + l;
            for (; i < arrN.Length; i++)
            {
                if (arrN[i] < minValue)
                {
                    minValue = arrN[i];
                    maxValueIndicator = i;
                }
            }
            arrN[maxValueIndicator] = arrN[l];
            arrN[l] = minValue;
        }
        for (int i = 0; i < arrN.Length; i++)
        {
            Console.WriteLine(arrN[i]);
        }
    }
}