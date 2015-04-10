
    //Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
    //    If an invalid number or non-number text is entered, the method should throw an exception.
    //Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;
class EnterNumbers
{
    public static Random rand = new Random();
    static int least = 1;
    const int greatest = 100;
    public static int index = 0;
    static void Main()
    {
        for (index = 0; index < 10; index++)
        {
            ReadNumber(least, greatest);
        }
    }

    private static int ReadNumber(int start, int end)
    {
        Console.WriteLine("Enter a number between {0} and {1}", least, greatest);
        int number = int.Parse(Console.ReadLine());
        CatchEx(number);
        least = number;
        return number;
    }

    private static void CatchEx(int number)
    {
        try
        {
            if (number <= least || number >= greatest)
            {
                throw new ArgumentException();
            }
        }
        catch (FormatException fe)
        {
            Console.WriteLine(fe.Message);
        }
        catch (ArgumentOutOfRangeException aoor)
        {
            Console.WriteLine(aoor.Message);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The number must be between {0} and {1}", least, greatest);
            index--;
        }
    }
}