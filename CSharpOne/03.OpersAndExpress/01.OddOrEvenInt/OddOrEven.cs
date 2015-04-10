//Write an expression that checks if given integer is odd or even.
using System;
class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Enter integer:");

        int num = int.Parse(Console.ReadLine());
        //This one's simple - we parse an integer through the console, then check with the % operator wether it has
        //1 leftover after division by two - hence if it's odd or even and print a bool answer as per the instructions.
        Console.WriteLine("Integer is Odd: {0}", num % 2 == 1);
        Console.WriteLine("Press any key to close...");
        Console.ReadLine();
    }
}
