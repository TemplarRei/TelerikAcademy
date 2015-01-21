//Write a Boolean expression that returns if the bit
//at position p (counting from 0, starting from the right) in given integer number n, has value of 1.
using System;
class CheckBitAtPosition
{
    static void Main()
    {

        Console.WriteLine("Enter integer for extraction:");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter position of bit for extraction:");
        sbyte bit = sbyte.Parse(Console.ReadLine());

        string numBinary = Convert.ToString(num, 2).PadLeft(32, '0');

        //we use a bool to check the value of the bit at desired position by asking if the number and 1, 
        //moved the desired distance (value bit) are the same. From there on out it's the same as the above. Check 11. for
        //explanation.
        bool bitCheck = (num & (1 << bit)) == 1;

        Console.WriteLine("The number in binary is: {0}", numBinary);
        Console.WriteLine("Bit #{0} is 1: {1}", bit, bitCheck);
        Console.ReadLine();
    }
}