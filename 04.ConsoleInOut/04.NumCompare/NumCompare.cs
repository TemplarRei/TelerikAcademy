//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.
using System;
class NumCompare
{
    static void Main()
    {
        //input
        Console.WriteLine("Enter first number:");
        float one = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        float two = float.Parse(Console.ReadLine());
        //output
        float answer;
        answer = (one < two ? two : one);
        Console.WriteLine("The bigger number is: " + answer);
    }
}