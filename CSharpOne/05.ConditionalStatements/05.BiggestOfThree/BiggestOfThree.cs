﻿//Write a program that finds the biggest of three numbers.
using System;
    class BiggestOfThree
    {
        static void Main()
        {
            Console.WriteLine("Enter first number:");
            double firstNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double secondNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            double thirdNum = double.Parse(Console.ReadLine());

            if (firstNum >= secondNum && firstNum >= thirdNum)
            {
                Console.WriteLine(firstNum);
            }
            else if (secondNum >= firstNum && secondNum >= thirdNum)
            {
                Console.WriteLine(secondNum);
            }
            else if (thirdNum >= firstNum && thirdNum >= secondNum)
            {
                Console.WriteLine(thirdNum);
            }
        }
    }