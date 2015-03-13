//    Write a method that reverses the digits of given decimal number.
//Example:
//input 	output
//256 	652
//123.45 	54.321
using System;
class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter an integer:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(Reverse(number));
    }

    private static int Reverse(int number)
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
}