//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n 
//to hold the value v at the position p from the binary representation of n while preserving all other bits in n.
using System;
class ModifyBitAtPosition
{
    static void Main()
    {
        Console.WriteLine("Enter integer for extraction:");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter position of bit for extraction:");
        sbyte bit = sbyte.Parse(Console.ReadLine());

        Console.WriteLine("Enter wanted value of bit #{0}", bit);
        sbyte value = sbyte.Parse(Console.ReadLine());

        string numBinary = Convert.ToString(num, 2);
        Console.WriteLine("The original number in binary is: {0}", numBinary.PadLeft(32, '0'));

        int newBitValue;
        int bitValue;

        //Here we use one of the many solutions an if-else ref. if the desired value is one, we mask with one and change 
        //it to that, by using movement described above in 11. If we want it to be a 0, we use reverse logic, 
        //by simply adding ~ :D.
        if (value == 1)
        {
            bitValue = 1 << bit;
            newBitValue = num | bitValue;
            Console.WriteLine("The binary value of {0} is {1}", num, Convert.ToString(newBitValue, 2).PadLeft(32, '0'));
            Console.WriteLine("Result = " + newBitValue);
        }
        else if (value == 0)
        {
            bitValue = ~(1 << bit);
            newBitValue = num & bitValue;
            Console.WriteLine("The binary value of {0} is {1}", num, Convert.ToString(newBitValue, 2).PadLeft(32, '0'));
            Console.WriteLine("The resulting decimal value of {0} is {1}", num, newBitValue);
        }
        else
        {
            Console.WriteLine("Bits can only have a value of 1 or 0.");
        }
    }
}