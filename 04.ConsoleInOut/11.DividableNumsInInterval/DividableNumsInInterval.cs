//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the 
//reminder of the division by 5 is 0.
using System;
class DividableNumsInInterval
{
    static void Main()
    {
        Console.WriteLine("Enter first positive integer:");
        uint one = uint.Parse(Console.ReadLine());
        Console.WriteLine("Enter first positive integer:");
        uint two = uint.Parse(Console.ReadLine());

        uint p = 0;

        for (uint i = one; i < two; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write("|{0}", i);
                p++;
            }

        }
        Console.WriteLine("|" + Environment.NewLine + "P = {0}", p);
    }
}