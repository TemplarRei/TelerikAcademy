//Write an expression that extracts from given integer n the value of given bit at index p.
using System;
class ExtractBitFromInt
{
    static void Main()
    {
        Console.WriteLine("Enter integer for extraction:");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter position of bit for extraction:");
        sbyte bit = sbyte.Parse(Console.ReadLine());

        string numBinary = Convert.ToString(num, 2).PadLeft(32, '0');

        //same as the above, really. Check out 11. for the explanation to this one too, but use user input instead of bit #3
        Console.WriteLine("The number in binary is: {0}", numBinary);
        Console.WriteLine("The bit #{0} in {1} is: {2}", bit, num, ((num >> bit) & 1));
        Console.ReadLine();
    }
}