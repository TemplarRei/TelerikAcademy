    //Write a program that reads an integer number and calculates and prints its square root.
    //    If the number is invalid or negative, print Invalid number.
    //    In all cases finally print Good bye.
    //Use try-catch-finally block.

using System;
class Sqrt
{
    static void Main()
    {
        Console.WriteLine("enter a positive number:");
        try
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(number));
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid number. You made the program sad!");
        }
        finally
        {
            Console.WriteLine("Good bye.");
        }
    }
}