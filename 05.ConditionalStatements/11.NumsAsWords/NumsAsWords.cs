//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
using System;
class NumsAsWords
{
    private static string[] digits = {
    "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"
                                     };

    private static string[] teens = {
    "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
                                    };

    private static string[] tens = {
    "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"
                                   };

    static void Main()
    {
        Console.WriteLine("Enter a number between 0 and 999:");
        int num = int.Parse(Console.ReadLine());

        if (num < 0 || num > 999)
        {
            Console.WriteLine("Out of range");
            Environment.Exit(0);
        }

        if (num == 0)
        {
            Console.WriteLine("Zero");
        }

        int digit = num % 10;

        if (num == 10 || num > 19 && num < 100)
        {
            num /= 10;
            int ten = num % 10;

            if (digit == 0)
            {
                Console.WriteLine("{0}", tens[ten - 1]);
            }

            else
            {
                Console.WriteLine("{0} {1}", tens[ten - 1], digits[digit]);
            }
        }

        else if (num < 10)
        {
            Console.WriteLine("{0}", digits[digit]);
        }

        else if (num >= 100)
        {

            num /= 10;
            int ten = num % 10;
            num /= 10;
            int hundreds = num % 10;

            if (ten == 0)
            {
                if (digit == 0)
                {
                    Console.WriteLine("{0} hundred", digits[hundreds]);
                }

                else
                {
                    Console.WriteLine("{0} hundred and {1}", digits[hundreds], digits[digit]);
                }
            }

            else
            {
                Console.WriteLine("{0} hundred and {1} {2}", digits[hundreds], tens[ten - 1], digits[digit]);
            }
        }

        else if (num < 20 && num > 10)
        {
            int teen = (num - 1) % 10;
            Console.WriteLine(teens[teen]);
        }
    }
}