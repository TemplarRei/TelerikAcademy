//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
using System;
using System.Linq;
    class OddAndEvenProduct
    {
        static void Main()
        {
            Console.WriteLine("Enter integers separated by space: ");
            int[] nums = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();

            long oddResult = 1;
            long evenResult = 1;
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0)
                {
                    oddResult *= nums[i];
                }
                else
                {
                    evenResult *= nums[i];
                }
            }
            if (oddResult == evenResult)
            {
                Console.WriteLine("product = {0}", oddResult);
            }
            else
            {
                Console.WriteLine("odd_product = {0} \neven_product = {1}", oddResult, evenResult);
            }
        }
    }