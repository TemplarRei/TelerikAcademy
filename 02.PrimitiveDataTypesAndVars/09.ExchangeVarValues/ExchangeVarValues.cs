//Declare two integer variables a and b and assign them with 5 and 10 and after that 
//exchange their values by using some programming logic.
//Print the variable values before and after the exchange.
using System;
class ExchangeVarValues
{
    static void Main()
    {
        //Here we use a temp value to exchange the two. We save the first as temp, replace the second to the first
        //and put the temp as second.
        int a = 5;
        int b = 10;
        Console.WriteLine("{0} {1}", a, b);
        int tempB = b;
        b = a;
        a = tempB;
        Console.WriteLine("{0} {1}", a, b);
    }
}