//Write a program that reads two integer arrays from the console and compares them element by element.
using System;
class CompareArrays
{
    static void Main()
    {
        //Declare first arr
        Console.WriteLine("Enter length for the first array:");
        int lenghtN = int.Parse(Console.ReadLine());
        int[] numsN = new int[lenghtN];

        Console.WriteLine("Enter {0} integers to fill, each on a separate line:", lenghtN);
        for (int i = 0; i < numsN.Length; i++)
        {
            int temp = int.Parse(Console.ReadLine());
            numsN[i] = temp;
        }

        //Declare second arr
        Console.WriteLine("Enter length for the second array:");
        int lenghtM = int.Parse(Console.ReadLine());
        int[] numsM = new int[lenghtM];
        bool lenght = true;

        Console.WriteLine("Enter {0} integers to fill, each on a separate line:", lenghtM);
        for (int i = 0; i < numsM.Length; i++)
        {
            int temp = int.Parse(Console.ReadLine());
            numsM[i] = temp;
        }

        //Compare
        if (numsN.Length != numsM.Length)
        {
            Console.WriteLine(
                "The two arrays do not have equal lenghts, they will be compared to the end of the shorter one.");
            lenght = false;
        }

        for (int i = 0; i < Math.Min(numsN.Length, numsM.Length); i++)
        {
            if (numsN[i] > numsM[i])
            {
                Console.WriteLine("{0} - First array entry is greater", i);
            }

            else if (numsN[i] < numsM[i])
            {
                Console.WriteLine("{0} - Second array entry is greater", i);
            }

            else if (numsN[i] == numsM[i])
            {
                Console.WriteLine("{0} - Equal entries", i);
            }
        }

        if (!lenght)
        {
            Console.WriteLine("End of the shorter array.");
        }
    }
}