//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.
using System;
class IntegerCalculations
{
    static void Main()
    {
        Console.WriteLine("Enter a int array, separated by comas:");
        int[] arr = { 7, 107, 1, 2, 132, 5, 2, 9, 3, 2, 9, 3, 5, 1 }; /*Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray().;*/

        int minimum = FindMinimum(arr);
        Console.WriteLine("The minimum is: {0}", minimum);

        int maximum = FindMaximum(arr);
        Console.WriteLine("The maximum is: {0}", maximum);

        int average = FindAverage(arr);
        Console.WriteLine("The average is: {0}", average);

        int sum = FindSum(arr);
        Console.WriteLine("The sum is: {0}", sum);

        long product = FindProduct(arr);
        Console.WriteLine("The product is: {0}", product);
    }

    private static long FindProduct(int[] arr)
    {
        long product = 1;
        foreach (var number in arr)
        {
            product *= number;
        }
        return product;
    }

    private static int FindSum(int[] arr)
    {
        int sum = 0;
        foreach (var number in arr)
        {
            sum += number;
        }
        return sum;
    }

    private static int FindAverage(int[] arr)
    {
        long sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        int average = (int)(sum / arr.Length);
        return average;
    }

    private static int FindMaximum(int[] arr)
    {
        int maximum = int.MinValue;
        foreach (var number in arr)
        {
            if (number > maximum)
            {
                maximum = number;
            }
        }
        return maximum;
    }

    private static int FindMinimum(int[] arr)
    {
        int minimum = int.MaxValue;
        foreach (var number in arr)
        {
            if (number < minimum)
            {
                minimum = number;
            }
        }
        return minimum;
    }
}