//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.
using System;
class ExtractBitThree
{
    static void Main()
    {
        Console.WriteLine("Type a positive decimal integer:");
        uint num = uint.Parse(Console.ReadLine());
        
        string numBinary = Convert.ToString(num, 2).PadLeft(32, '0');

        //Easiest bitwise operation - we move the bits of the int to the left with three and compare them with 1 
        //(binary 0001) - if it's one, we print true (represented by binary 1), 
        //if it's 0 we print false (represented by binary 0)
        Console.WriteLine("The number in binary is: {0}", numBinary);
        Console.WriteLine("The bit #3 in {0} is: {1}", num, ((num >> 3) & 1));
        Console.ReadLine();
    }
}