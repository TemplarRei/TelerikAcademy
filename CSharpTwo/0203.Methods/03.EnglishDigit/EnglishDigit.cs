//    Write a method that returns the last digit of given integer as an English word.
//Examples:
//input 	output
//512 	two
//1024 	four
//12309 	nine
using System;
using System.Collections.Generic;
using System.Linq;
class EnglishDigit
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(GetDigit(number));

    }

    private static string GetDigit(int number)
    {
        string digit = string.Empty;
        switch (number % 10)
        {
            case 0: digit = "Zero"; break;
            case 1: digit = "One"; break;
            case 2: digit = "Two"; break;
            case 3: digit = "Three"; break;
            case 4: digit = "Four"; break;
            case 5: digit = "Five"; break;
            case 6: digit = "Six"; break;
            case 7: digit = "Seven"; break;
            case 8: digit = "Eight"; break;
            case 9: digit = "Nine"; break;
        }
        return digit;
    }
}