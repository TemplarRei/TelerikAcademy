//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
using System;
class BitsExchange
{
    static void Main()
    {
        Console.WriteLine("Enter a positive integer:");
        uint num = uint.Parse(Console.ReadLine());

        uint smallBits = num & 56;
        uint largeBits = num & 117440512;

        //We use a bit of a cheaty solution to this one - instead of properly masking the bits, we use integers that only have
        //1s in the desired slots (check 56 and 117440512 in the calculator). the | operator helps us swap around the 1s and 0s
        //by making a difference in bits a 1. 
        uint finalInt = num & ~(56 | (uint)117440512);
        finalInt |= smallBits << 21;
        finalInt |= largeBits >> 21;


        Console.WriteLine("The integer in binary before the conversion is: \n{0}",
            Convert.ToString(num, 2).PadLeft(32, '0'));
        Console.WriteLine("The integer in binary after the conversion is: \n{0}",
            Convert.ToString(finalInt, 2).PadLeft(32, '0'));
        Console.WriteLine("The integer after conversion is: {0}", finalInt);
        Console.ReadLine();
    }
}