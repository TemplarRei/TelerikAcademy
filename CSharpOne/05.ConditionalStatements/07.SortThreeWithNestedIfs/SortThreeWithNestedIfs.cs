//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.
using System;
class SortThreeWithNestedIfs
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        double firstNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        double secondNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        double thirdNum = double.Parse(Console.ReadLine());

        if (firstNum >= secondNum)
        {
            if (firstNum >= thirdNum)
            {
                if (secondNum >= thirdNum)
                {
                    Console.WriteLine("{0} {1} {2}", firstNum, secondNum, thirdNum);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", firstNum, thirdNum, secondNum);
                }
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", thirdNum, firstNum, secondNum);
            }
        }
        else if (secondNum >= firstNum)
        {
            if (secondNum >= thirdNum)
            {
                if (firstNum >= thirdNum)
                {
                    Console.WriteLine("{0} {1} {2}", secondNum, firstNum, thirdNum);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", secondNum, thirdNum, firstNum);
                }
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", thirdNum, secondNum, firstNum);
            }
        }
        
    }
}