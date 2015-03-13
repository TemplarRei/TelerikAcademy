//Write a program that finds the biggest of five numbers by using only five if statements.
using System;
class BiggestOfFive
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        double firstNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        double secondNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        double thirdNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter fourth number:");
        double fourthNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter fifth number:");
        double fifthNum = double.Parse(Console.ReadLine());

        if (firstNum >= secondNum && firstNum >= thirdNum && firstNum >= fourthNum && firstNum >= fifthNum)
        {
            Console.WriteLine(firstNum);
        }
        else if (secondNum >= firstNum && secondNum >= thirdNum && secondNum >= fourthNum && secondNum >= fifthNum)
        {
            Console.WriteLine(secondNum);
        }
        else if (thirdNum >= firstNum && thirdNum >= secondNum && thirdNum >= fourthNum && thirdNum >= fifthNum)
        {
            Console.WriteLine(thirdNum);
        }
        else if (fourthNum >= firstNum && fourthNum >= secondNum && fourthNum >= thirdNum && fourthNum >= fifthNum)
        {
            Console.WriteLine(fourthNum);
        }
        else if (fifthNum >= firstNum && fifthNum >= secondNum && fifthNum >= thirdNum && fifthNum >= fourthNum)
        {
            Console.WriteLine(fifthNum);
        }
    }
}