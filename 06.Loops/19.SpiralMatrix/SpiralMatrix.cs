//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix holding 
//the numbers from 1 to n*n in the form of square spiral like in the examples below.
using System;
class SpiralMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter value for n:");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        int counter = 1;
        int spiralCentre = n / 2;
        int rowBrowse = 0;

        while (rowBrowse < spiralCentre)
        {

            for (int i = rowBrowse; i < (n - rowBrowse); i++)
            {
                matrix[rowBrowse, i] = counter;
                counter++;
            }

            for (int i = rowBrowse + 1; i < (n - rowBrowse); i++)
            {
                matrix[i, (n - 1 - rowBrowse)] = counter;
                counter++;
            }

            for (int i = (n - 2 - rowBrowse); i >= rowBrowse; i--)
            {
                matrix[(n - 1 - rowBrowse), i] = counter;
                counter++;
            }

            for (int i = (n - rowBrowse - 2); i >= (rowBrowse + 1); i--)
            {
                matrix[i, rowBrowse] = counter;
                counter++;
            }

            rowBrowse++;

            if (n % 2 == 1)
            {
                matrix[spiralCentre, spiralCentre] = counter;
            }
        }

        for (int i = 0; i < n; i++)
        {

            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,-4}", matrix[i, j]);
            }

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}