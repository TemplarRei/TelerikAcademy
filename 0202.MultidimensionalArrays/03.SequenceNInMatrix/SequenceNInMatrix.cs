using System;
using System.Collections.Generic;
using System.Linq;
class SequenceNInMatrix
{
    static readonly int[,] directions = { { 0, 1 }, { 1, 1 }, { -1, 1 }, { 1, 0 } };
    static void Main()
    {
        string[,] matrix = {{"ha", 	"fifi",	"ho", 	"hi"},
                            {"fo", 	"ha",	"hi", 	"xx"},
                            {"xxx", "ho", 	"ha",	"xx"}}; /*ReadMatrix();*/
        int finalLenght = 0;
        string finalElement = string.Empty;

        FindLongestSequence(matrix, ref finalElement, ref finalLenght);
        for (int i = 0; i < finalLenght; i++)
        {
            Console.Write("{0}, ", finalElement);
        }
        Console.WriteLine("\b\b \n");
    }

    private static void FindLongestSequence(string[,] matrix, ref string finalElement, ref int finalLenght)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int direction = -1;
                while (++direction < 4)
                {
                    int currentRow = row + directions[direction, 0];
                    int currentCol = col + directions[direction, 1];
                    int currentLength = 1;

                    while (IsTraversible(matrix, row, col, currentRow, currentCol))
                    {
                        currentLength++;

                        if (currentLength > finalLenght)
                        {
                            finalLenght = currentLength;
                            finalElement = matrix[row, col];
                        }
                        currentRow += directions[direction, 0];
                        currentCol += directions[direction, 1];
                    }
                }
            }
        }
    }

    private static bool IsTraversible(string[,] matrix, int row, int col, int currentRow, int currentCol)
    {
        return currentRow >= 0 && currentRow < matrix.GetLongLength(0) &&
               currentCol >= 0 && currentCol < matrix.GetLongLength(1) &&
               matrix[currentRow, currentCol] == matrix[row, col];
    }

    private static string[,] ReadMatrix()
    {
        Console.WriteLine("Enter number of rows for the matrix:");
        Console.Write("Enter number of matrix rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter number of matrix columns: ");
        int cols = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, cols];
        Console.WriteLine("Enter each row on separate line and the numbers, separated by a comma: ");
        string[] tempRow;
        for (int currentRow = 0; currentRow < rows; currentRow++)
        {
            tempRow = Console.ReadLine()
            .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
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