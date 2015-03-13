//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//If the score is between 1 and 3, the program multiplies it by 10.
//If the score is between 4 and 6, the program multiplies it by 100.
//If the score is between 7 and 9, the program multiplies it by 1000.
//If the score is 0 or more than 9, the program prints “invalid score”.
using System;
class BonusScore
{
    static void Main()
    {
        Console.WriteLine("Enter score:");
        int scr = int.Parse(Console.ReadLine());

        if (scr < 0 || scr > 9)
        {
            Console.WriteLine("Invalid score.");
            Environment.Exit(0);
        }
        else if (scr <= 3)
        {
            scr *= 10;
        }
        else if (scr <= 6)
        {
            scr *= 100;
        }
        else if (scr <= 9)
        {
            scr *= 1000;
        }
        Console.WriteLine(scr);
    }
}