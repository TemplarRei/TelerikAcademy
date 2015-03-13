//Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) 
//using the \u00XX syntax, and then print it.
using System;
class UnicodeChar
{
    static void Main()
    {
        char asterix = '\u002a';

        Console.WriteLine(asterix);
    }
}