//Declare five variables choosing for each of them the most appropriate of the types 
//byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
using System;
class DeclareVars
{
    static void Main()
    {
        //I've named the vars one through five 'cause I won't use them and my imagination is poor...
        ushort one = 52130;
        sbyte two = -115;
        int three = 4825932;
        sbyte four = 97;
        short five = -10000;

        Console.WriteLine("Integers! {0}; {1}; {2}; {3}; {4}", one, two, three, four, five);
    }
}