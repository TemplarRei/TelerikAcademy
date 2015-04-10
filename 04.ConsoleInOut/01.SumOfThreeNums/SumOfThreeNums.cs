//Write a program that reads 3 real numbers from the console and prints their sum.
using System;
class SumOfThreeNums
{
    static void Main()
    {
        string numOne;
        string numTwo;
        string numThree;
        int num;
        //input
        do
        {
            Console.WriteLine("Enter first number:");
            numOne = Console.ReadLine();
        } while (!int.TryParse(numOne, out num));

        do
        {
            Console.WriteLine("Enter second number:");
            numTwo = Console.ReadLine();
        } while (!int.TryParse(numTwo, out num));

        do
        {
            Console.WriteLine("Enter third number:");
            numThree = Console.ReadLine();
        } while (!int.TryParse(numThree, out num));

        int one = int.Parse(numOne);
        int two = int.Parse(numTwo);
        int three = int.Parse(numThree);

        //output
        Console.WriteLine("The sum of these numbers is: {0}", one + two + three);
        Console.ReadLine();
    }
}