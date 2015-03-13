//Which of the following values can be assigned to a variable of type float and which 
//to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.
using System;
class FloatOrDouble
{
    static void Main()
    {
        //I've named the vars one through four 'cause I won't use them and my imagination is poor...
        double one = 34.567839023;
        float two = 12.345f;
        float three = 8923.1234857f;
        float four = 3456.091f;

        Console.WriteLine("Decimals! {0} {1} {2} {3}", one, two, three, four);
    }
}