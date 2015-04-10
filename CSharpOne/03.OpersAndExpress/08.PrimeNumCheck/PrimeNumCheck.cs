//Write an expression that checks if given positive integer number n (n = 100) is prime 
//(i.e. it is divisible without remainder only to itself and 1).
using System;
class PrimeNumCheck
{
    static void Main()
    {
        Console.WriteLine("Type a number to check:");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("The number {0} prime.", IsPrime(num) ? "is" : "is not");
    }
    //I was really having a hard time with this one, until I found the IsPrime function - it works like magic. I'm really
    // bad at explaining it, but dotnetperls do a good job. Check them out here: http://www.dotnetperls.com/prime
    private static bool IsPrime(int num)
    {
        if ((num & 1) == 0)
        {
            if (num == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        for (int i = 3; (i * i) <= num; i += 2)
        {
            if ((num % i) == 0)
            {
                return false;
            }
        }
        return num != 1;
    }
}