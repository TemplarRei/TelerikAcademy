using System;
//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
class PrintSequence
{
    static void Main()
    {
        //First number in the sequence
        const int firstSequenceNumber = 2;

        //For loop to print the numbers (http://msdn.microsoft.com/en-us/library/ch45axte.aspx)
        for (int i = 0; i < 10; i++)
        {
            //To make each number greater than the last one by 1
            int number = i + firstSequenceNumber;

            //If-statement for even&odd numbers
            if (number % 2 != 0)
                number *= -1;

            //Printing the number in the console
            Console.WriteLine(number);
        }
    }
}