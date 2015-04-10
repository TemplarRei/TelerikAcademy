//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
//(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
using System;
    class FibonacciNums
    {
        static void Main()
        {
            Console.WriteLine("Enter number count to display:");
            int n = int.Parse(Console.ReadLine());
            
            UInt64 fibonacci = 0;
            UInt64 fibonacciTwo = 1;
            UInt64 temp;

            if (n <= 0)
            {
                Console.WriteLine("Type value bigger than 0:");
                n = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++ )
            {
                Console.Write("{0}, ", fibonacci);
                temp = fibonacci + fibonacciTwo;
                fibonacciTwo = fibonacci;
                fibonacci = temp;
            }
        }
    }