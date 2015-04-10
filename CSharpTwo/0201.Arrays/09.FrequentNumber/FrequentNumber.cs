//Write a program that finds the most frequent number in an array.
//Example:
//input 	                                |result
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 	|4 (5 times)
using System;
class FrequentNumber
{
    static void Main()
    {
        //input
        Console.WriteLine("Enter value for lenght N of the array:");
        /*int N = int.Parse(Console.ReadLine());*/
        int[] arrN = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };/*new int[N];

        Console.WriteLine("Enter the Array indexes:");
        for (int i = 0; i < N; i++)
        {
            Console.Write("Array[{0}]: ", i);
            arrN[i] = int.Parse(Console.ReadLine());
        }*/
        Array.Sort(arrN);

        int Counter = 1;
        int CounterFinal = 0;
        int number = arrN[0];
        for (int i = 1; i < arrN.Length; i++)
        {

            if (arrN[i] != arrN[i - 1])
            {
                Counter = 1;
            }
            if (arrN[i - 1] == arrN[i])
            {
                Counter++;

                if (Counter > CounterFinal)
                {
                    CounterFinal = Counter;
                    number = arrN[i];
                }
            }
        }
        Console.WriteLine("{0} repeats the most ({1}) times.", number, CounterFinal);
    }
}