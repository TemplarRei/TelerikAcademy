//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
//The first and the second sequence of bits may not overlap.
using System;
class BitsExchangeAdvanced
{
    static void Main()
    {
        Console.WriteLine("Enter unsigned integer: ");
        long num = long.Parse(Console.ReadLine());
        string finalNum = Convert.ToString(num, 2).PadLeft(32, '0');
        Console.WriteLine("Enter position of bit P: ");
        int bitP = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position of bit Q: ");
        int bitQ = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of bits (K) that will be exchanged: ");
        int countK = int.Parse(Console.ReadLine());
        //Oh, boy, I'm really going to try and explain this one. To be honest, It took me around two days 
        //and reading through some few thousand lines of code and forums to get this one.

        //First we use an if-else ref to clear Out of range and overlapping values, that's simple enough.
        if (bitP < 0 || bitP > 32 || bitP + countK > 32 || bitQ < 0 || bitQ > 32 || bitQ + countK > 32)
        {
            Console.WriteLine("Out of range.");
        }
        else if ((bitP > bitQ && bitQ + countK >= bitP) || (bitQ > bitP && bitP + countK >= bitQ)
            || (bitP == bitQ))
        {
            Console.WriteLine("Overlapping values.");
        }
        else
        {
            Console.WriteLine("The number before conversion is: {0}", Convert.ToString(num, 2).PadLeft(32, '0'));
            //now we mask Q, because we're going to need to increase it, but want to still know the original value
            int maskQ = bitQ;
            //with a for loop we make the increment from p to p+k-1, so we don't have to enter it manually
            for (int i = bitP; i <= bitP + countK - 1; i++)
            {
                //we create ourselves a mask and I'll let our esteemed lecturer 
                //Ivailo explain this one, because it gets MESSY. Gotta love old workshops
                //https://www.youtube.com/watch?v=8vxQqbFGW-E
                int mask = 1;

                long smallBits = ((mask << i) & num) >> i;
                long largeBits = ((mask << maskQ) & num) >> maskQ;

                num = num & ~(mask << i);
                num = num & ~(mask << maskQ);
                num = num | (largeBits << i);
                num = num | (smallBits << maskQ);

                maskQ++;
            }
            Console.WriteLine("The number after conversion is {0} and in binary: \n{1}", num, Convert.ToString(num, 2).PadLeft(32, '0'));
            Console.WriteLine(finalNum + "\n(Above is a checkup line with the starting binary int)");
            Console.ReadLine();
        }
    }
}