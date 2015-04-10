//Write a program that generates and prints to the console 10 random values in the range [100, 200].
using System;

namespace _02.RandNums
{
    class RandNums
    {
        public static Random rand = new Random();
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rand.Next(100, 201));
            }
        }
    }
}
