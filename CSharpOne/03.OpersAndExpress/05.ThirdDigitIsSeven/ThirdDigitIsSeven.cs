//Write an expression that checks for given integer if its third digit from right-to-left is 7.
using System;
class ThirdDigitIsSeven
{
    static void Main()
    {
        Console.Write("Enter an integer:");
        int num = int.Parse(Console.ReadLine());
        //It gets a liiiiitle bit complicated here - we divide the int by 100, thus making the third digit - last 
        //(it's an int, so no floating point). Then we check wether it has 7 leftover after division by 10 - 
        //that'd be the first digit after the floating point.
        bool isItSeven = ((num / 100) % 10) == 7;

        Console.WriteLine("The third digit is 7 ----> " + isItSeven);
        Console.ReadLine();
    }
}