//Write a program that can solve these tasks:
//       Reverses the digits of a number
//       Calculates the average of a sequence of integers
//       Solves a linear equation a * x + b = 0
//   Create appropriate methods.
//   Provide a simple text-based menu for the user to choose which task to solve.
//   Validate the input data:
//       The decimal number should be non-negative
//       The sequence should not be empty
//       a should not be equal to 0
using System;
class SolveTasks
{
    static void Main()
    {
        Console.WriteLine("Select a mode:");
        Console.WriteLine("Type 1 to reverse a number.");
        Console.WriteLine("Type 2 to calculate the average of a int sequence.");
        Console.WriteLine("Type 3 to solve a linear equation.");
        byte decision = byte.Parse(Console.ReadLine());
        Decide(decision);
        

    }

    private static void Decide(byte decision)
    {
        if (decision == 1)
        {
            Console.WriteLine("Enter a number for reversion:");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("The number must be non-negative.");
                return;
            }
            int reverseNumber = ReverseNumber(number);
            Console.WriteLine(reverseNumber); ;
        }
        else if (decision == 2)
        {
            Console.WriteLine("Enter a int array, separated by comas:");
            int[] arr = { 7, 107, 1, 2, 132, 5, 2, 9, 0, 2, 9, 3, 5, 1 }; /*Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray().;*/
            if (arr.Length < 1)
            {
                Console.WriteLine("The array must not be empty");
                return;
            }
            int average = CalculateAverage(arr);
            Console.WriteLine(average);
        }
        else if (decision == 3)
        {
            Console.WriteLine("Enter value of a, where a != 0:");
            int a = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("a must not be equal to 0");
                return;
            }
            Console.WriteLine("Enter value of b:");
            int b = int.Parse(Console.ReadLine());
            int x = LinearEquation(a, b);
            Console.WriteLine(x);
        }
        else
        {
            Main();
        }
    }

    private static int LinearEquation(int a, int b)
    {
        int x = -b / a;
        return x;
    }

    private static int ReverseNumber(int number)
    {
        string reverseNumber = string.Empty;
        int temp;
        while (number > 0)
        {
            temp = number % 10;
            reverseNumber = reverseNumber + temp.ToString();
            number /= 10;
        }
        return int.Parse(reverseNumber);
    }

    private static int CalculateAverage(int[] arr)
    {
        long sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        int average = (int)(sum / arr.Length);
        return average;
    }
    
}