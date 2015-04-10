//    Write a method that asks the user for his name and prints “Hello, <name>”
//    Write a program to test this method.
//Example:
//input 	output
//Peter 	Hello, Peter!
using System;
using System.Collections.Generic;
using System.Linq;
class SayHello
{
    static void Main()
    {
        Console.WriteLine(SayHi());
    }

    private static string SayHi()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        string hi = "Hello, " + name;
        return hi;
    }
}