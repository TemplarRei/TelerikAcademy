using System;
class StringLenght
{
    static void Main()
    {
        string str = "apigwrqwerifjndva"; //Console.ReadLine();
        try
        {
        if (str.Length > 20)
        {
            throw new ArgumentException("The string is longer than 20 characters.");
        }
        else
        {
            Console.WriteLine(str.PadRight(20, '*'));
        }
        }

        catch (ArgumentException exept)
        {
            Console.WriteLine("{0}", exept.Message);
        }
    }
}
