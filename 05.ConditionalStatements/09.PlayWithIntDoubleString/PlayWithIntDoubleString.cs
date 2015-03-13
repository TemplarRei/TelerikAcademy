//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.
using System;
class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please type:\n\n1->int\n\n2->double\n\n3->string\n");
        sbyte selection = sbyte.Parse(Console.ReadLine());

        if (selection < 1 || selection > 3)
        {
            Console.WriteLine("Wrong selection.");
            Environment.Exit(0);
        }

        if (selection == 1)
        {
            Console.WriteLine("Enter value for the int:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(num + 1);
        }
        else if (selection == 2)
        {
            Console.WriteLine("Enter value for the double:");
            double num = double.Parse(Console.ReadLine());

            Console.WriteLine(num + 1);
        }
        else if (selection == 3)
        {
            Console.WriteLine("Enter string:");
            string str = Console.ReadLine();

            Console.WriteLine("{0}*", str);
        }
    }
}