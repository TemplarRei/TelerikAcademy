//Write a program that fills and prints a matrix of size (n, n) as shown below:
//Example for n=4:
//|a) 	 	 	    |d)*	        |b)             |c)	
//|1 	5 	9 	13  |1 	12 	11 	10  |1 	8 	9 	16  |7 	11 	14 	16
//|2 	6 	10 	14  |2 	13 	16 	9   |2 	7 	10 	15  |4 	8 	12 	15
//|3 	7 	11 	15  |3 	14 	15 	8   |3 	6 	11 	14  |2 	5 	9 	13
//|4 	8 	12 	16  |4 	5 	6 	7   |4 	5 	12 	13  |1 	3 	6 	10

using System;
using System.Collections.Generic;
using System.Linq;
class FillTheMatrixA
{
    static void Main()
    {
        Console.WriteLine("Enter value for n:");
        int n = 4;// int.Parse(Console.ReadLine());
        Console.WriteLine("Select a method for drawing: \n| A | B | C | D |\n");
        string selection = Console.ReadLine();
        int[,] matrix = new int[n, n];
        switch (selection)
        {
            case "a":
            case "A": matrix = DrawingA(n); break;
            case "b":
            case "B": matrix = DrawingB(n); break;
            case "c":
            case "C": matrix = DrawingC(n); break;
            case "d":
            case "D": matrix = DrawingD(n); break;
            default: Console.WriteLine("Not a valid selection."); break;
        }
        
        for (int i = 0; i < n; i++)
        {

            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,-3}", matrix[i, j]);
            }

            Console.WriteLine();
        }
    }
    static int[,] DrawingA(int n)
    {
        int[,] matrix = new int[n, n];
        int counter = 1;
        for (int rows = 0; rows < n; rows++)
        {
            for (int cols = 0; cols < n; cols++)
            {
                matrix[cols, rows] = counter;
                counter++;
            }
        }
        return matrix;
    }
    static int[,] DrawingB(int n)
    {
        int[,] matrix = new int[n, n];
        int counter = 1;
        for (int rows = 0; rows < n; rows++)
        {
            if (rows % 2 == 0)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    matrix[cols, rows] = counter;
                    counter++;
                }
            }
            else
            {
                for (int cols = n - 1; cols >= 0; cols--)
                {
                    matrix[cols, rows] = counter;
                    counter++;
                }
            }
        }
        return matrix;
    }
    static int[,] DrawingC(int n)
    {
        int[,] matrix = new int[n, n];
        int counter = 1;
        int index = 1;

        while (index <= n * n)
        {
            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    if (cols - rows + index == n)
                    {
                        matrix[cols, rows] = counter;
                        counter++;
                    }
                }
            }
            index++;
        }
        return matrix;
    }
    static int[,] DrawingD(int n)
    {
        int[,] matrix = new int[n, n];
        int[] rowIndex = new int[] { 1, 0, -1, 0 };
        int[] colIndex = new int[] { 0, 1, 0, -1 };
        int index = 1;
        int row = 0;
        int nextRow = 0;
        int col = 0;
        int nextCol = 0;
        int direction = 0;

        while (index <= n * n)
        {
            matrix[row, col] = index++;
            nextRow = row + rowIndex[direction];
            nextCol = col + colIndex[direction];
            if ((nextRow < 0 || nextRow >= n) || (nextCol < 0 || nextCol >= n) || matrix[nextRow, nextCol] != 0)
            {
                direction = (direction + 1) % 4;
            }
            row += rowIndex[direction];
            col += colIndex[direction];
        }
        return matrix;
    }
}