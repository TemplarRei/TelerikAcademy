using System;
using System.Collections.Generic;
using System.Linq;
class MaxSum
{
    static void Main()
    {
        // Declare and initialize the matrix
        int[,] matrix = ReadMatrix();
        /*{
        { 2, 2, 4, 0, 9, 5 },
        { 7, 1, 3, 3, 2, 1 },
        { 1, 3, 9, 8, 5, 6 },
        { 4, 6, 7, 9, 1, 0 }
        };*/

        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = 0;
                for (int platformRow = row; platformRow < row + 3; platformRow++)
                {
                    for (int platformCol = col; platformCol < col + 3; platformCol++)
                    {
                        sum += matrix[platformRow, platformCol];
                    }
                }
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        // Print the result
        Console.WriteLine("The best platform is:");
        for (int platformRow = bestRow; platformRow < bestRow + 3; platformRow++)
        {
            for (int platformCol = bestCol; platformCol < bestCol + 3; platformCol++)
            {
                Console.Write("{0, -2} ", matrix[platformRow, platformCol]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("The maximal sum is: {0}", bestSum);
    }

    private static int[,] ReadMatrix()
    {
        Console.Write("Enter number of matrix rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter number of matrix columns: ");
        int cols = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, cols];
        Console.WriteLine("Enter each row on separate line and the numbers, separated by a comma: ");
        int[] tempRow;
        for (int currentRow = 0; currentRow < rows; currentRow++)
        {
            tempRow = Console.ReadLine()
            .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();
            if (tempRow.Length != cols)
            {
                Console.WriteLine("The numbers you entered are more or less than the array size.");
                Environment.Exit(0);
            }
            for (int currentCol = 0; currentCol < cols; currentCol++)
            {
                matrix[currentRow, currentCol] = tempRow[currentCol];
            }
        }
        return matrix;
    }
}