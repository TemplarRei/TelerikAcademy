using System;
using System.Collections.Generic;
using System.Linq;
class LargestAreaInMatrix
{
    static bool[,] visited = new bool[1000, 1000];
    static int[] directionRows = { -1, 1, 0, 0 };
    static int[] directionCols = { 0, 0, -1, 1 };
    static int newRow;
    static int newCol;
    static void Main()
    {
        int[,] matrix = {{1, 3, 2, 	2, 	2, 	4},
                         {3, 3, 3, 	2, 	4, 	4},
                         {4, 3, 1, 	2, 	3, 	3},
                         {4, 3, 1, 	3, 	3, 	1},
                         {4, 3, 3, 	3, 	1, 	1}}; //ReadMatrix();

        int currentValue = 0;
        int maxValue = 0;
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                if (visited[rows, cols] == false)
                {
                    currentValue = DepthFirstSearch(matrix, rows, cols, matrix[rows, cols]);
                    if (currentValue > maxValue)
                    {
                        maxValue = currentValue;
                    }
                }
            }
        }
        Console.WriteLine(maxValue);
    }

    private static int DepthFirstSearch(int[,] matrix, int row, int col, int currentValue)
    {
        if (visited[row, col])
        {
            return 0;
        }
        else
        {
            visited[row, col] = true;
            int bestValue = 0;
            int bestRow = row;
            int bestCol = col;
            for (int i = 0; i < 4; i++)
            {
                int modRow = directionRows[i] + row;
                int modCol = directionCols[i] + col;

                if (modRow == -1 || modRow >= matrix.GetLength(0) ||
                    modCol == -1 || modCol >= matrix.GetLength(1))
                {
                    continue;
                }
                if (matrix[modRow, modCol] == currentValue)
                {
                    int nextValue = DepthFirstSearch(matrix, modRow, modCol, currentValue);
                    bestValue += nextValue;
                }
                newRow = bestRow;
                newCol = bestCol;
            }
            return bestValue + 1;
        }
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