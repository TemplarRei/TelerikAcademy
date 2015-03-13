using System;
class FormatNumber
{
    static void Main()
    {
        int number = 33; //int.Parse(Console.ReadLine());

        Console.WriteLine("{0:D}", number);
        Console.WriteLine("{0:X}", number);
        Console.WriteLine("{0:P}", number); 
        Console.WriteLine("{0:E}", number);
    }
}