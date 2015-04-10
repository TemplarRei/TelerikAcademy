//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.
using System;
class NullValuesArithmetic
{
    static void Main()
    {
        int num = new int();
        double dec = new double();

        Console.WriteLine(num);
        Console.WriteLine(dec);

        int? nullNum = null;
        double? nullDec = null;
        Console.WriteLine(nullNum);
        Console.WriteLine(nullDec);

        num += 13;
        dec += 13;
        
        Console.WriteLine(num);
        Console.WriteLine(dec);
    }
}
