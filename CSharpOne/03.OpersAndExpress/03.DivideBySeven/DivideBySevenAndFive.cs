//Write a Boolean expression that checks for given integer if it can be divided (without remainder) 
//by 7 and 5 at the same time.
using System;
class DivideBySevenAndFive
{
    static void Main()
    {
        Console.WriteLine("Enter an integer:");
        int num = int.Parse(Console.ReadLine());

        //We check wether the number chosen is divisible by the multiple of seven and five - the lowest integer 
        //that is divisible by both of them.
        if (num % 35 == 0)
        {
            Console.WriteLine("The integer is divisible by seven and five.");
        }
        else
        {
            Console.WriteLine("The integer is not divisible by seven and five.");
        }
        Console.WriteLine("Press any key to close...");
        Console.ReadLine();
    }
}