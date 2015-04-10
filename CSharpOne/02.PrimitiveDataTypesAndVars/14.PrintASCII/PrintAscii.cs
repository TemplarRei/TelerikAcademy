//Find online more information about ASCII (American Standard Code for Information Interchange) 
//and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
using System;
class PrintAscii
{
    static void Main()
    {
        //First we make a makeshift table to hold the symbols.
        Console.Write("Decimal".PadRight(10));
        Console.Write("ASCII".PadRight(10));
        Console.Write("Hex".PadRight(10));
        Console.WriteLine();

        int min = 0;
        int max = 128;
        //Then with a for loop we print:
        //a) for the places where the symbol can't be printed we force it in.
        //b) control, for the control symbol of the ASCII table (I've got NO idea what it does.)
        //c) we let the loop type the others with .ToString :)
        for (int i = min; i < max; i++)
        {
            char c = (char)i;

            string display = string.Empty;
            if (char.IsWhiteSpace(c))
            {
                display = c.ToString();
                switch (c)
                {
                    case '\t':
                        display = "\\t";
                        break;
                    case ' ':
                        display = "space";
                        break;
                    case '\n':
                        display = "\\n";
                        break;
                    case '\r':
                        display = "\\r";
                        break;
                    case '\v':
                        display = "\\v";
                        break;
                    case '\f':
                        display = "\\f";
                        break;
                }
            }
            else if (char.IsControl(c))
            {
                display = "control";
            }
            else
            {
                display = c.ToString();
            }
            Console.Write(i.ToString().PadRight(10));
            Console.Write(display.PadRight(10));
            Console.Write(i.ToString("X2"));
            Console.WriteLine();
        }
    }
}