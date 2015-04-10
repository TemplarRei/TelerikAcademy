    //Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
    //Each of the numbers that will be added could have up to 10 000 digits.
using System;
using System.Numerics;
class NumberAsArray
{
    static void Main()
    {
        Console.WriteLine("Enter your first int array, separated by comas:");
        int[] arrOne = { 7, 7, 1, 2, 3, 5, 2, 9, 2, 9, 3, 5, 1 }; /*Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray().;*/
        Console.WriteLine("Enter your second int array, separated by comas:");
        int[] arrTwo = { 4, 7, 1, 9, 3, 6, 9, 2, 9, 9 }; /*Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();*/

        int[] finalArr = SumArrs(arrOne, arrTwo);
        Console.WriteLine(string.Join("", finalArr));
    }

    private static int[] SumArrs(int[] arrOne, int[] arrTwo)
    {
        int max = Math.Max(arrOne.Length, arrTwo.Length);
        int[] equalArrOne = new int[max];
        int[] equalArrTwo = new int[max];

        for (int i = 0; i < arrOne.Length; i++)
        {
            equalArrOne[i] = arrOne[i];
        }
        for (int i = 0; i < arrTwo.Length; i++)
        {
            equalArrTwo[i] = arrTwo[i];
        }
        Array.Reverse(equalArrOne);
        Array.Reverse(equalArrTwo);

        int[] finalArr = new int[equalArrOne.Length + 1];
        int carryOver = 0;

        for (int i = 0; i < equalArrOne.Length; i++)
        {
            if (equalArrOne[i] + equalArrTwo[i] >= 10)
            {
                finalArr[i] = (equalArrOne[i] + equalArrTwo[i]) % 10;
                carryOver = 1;
            }
            else
            {
                finalArr[i] = equalArrOne[i] + equalArrTwo[i] + carryOver;
                carryOver = 0;
            }
        }
        if (carryOver == 1)
        {
            finalArr[finalArr.Length - 1] = 1;
        }
        if (carryOver == 0)
        {
            int[] finalArrShort = new int[finalArr.Length - 1];
            for (int i = 0; i < finalArrShort.Length; i++)
            {
                finalArrShort[i] = finalArr[i];

            }
            Array.Reverse(finalArrShort);
            return finalArrShort;
        }
        Array.Reverse(finalArr);
        return finalArr;
    }
}