using System;
using System.Text;
class MatrixClass
{
    static void Main()
    {

        Matrix matrixOne = new Matrix(4, 4,
                                4, 2, 3, 5,
                                1, 2, 3, 4,
                                5, 6, 7, 8,
                                9, 0, 1, 2);
        Matrix matrixTwo = new Matrix(4, 4,
                                1, 2, 3, 4, 
                                1, 3, 5, 7,
                                2, 4, 6, 8,
                                0, 1, 1, 2);

        Console.WriteLine("First Matrix is:");
        Console.WriteLine(matrixOne);
        Console.WriteLine("Second Matrix is:");
        Console.WriteLine(matrixTwo);
        Console.WriteLine("Addition of the Matrices:");
        Console.WriteLine(matrixOne + matrixTwo);
        Console.WriteLine("Subtraction of the Matrices:");
        Console.WriteLine(matrixOne - matrixTwo);
        Console.WriteLine("Multiplication of the Matrices:");
        Console.WriteLine(matrixOne * matrixTwo);
    }
    class Matrix
    {
        private readonly int Rows;
        private readonly int Cols;
        private readonly int[,] matrix;

        private Matrix(int rows, int cols)
            : this(rows, cols, new int[] { })
        { }
        public Matrix(int rows, int cols, params int[] numbers)
        {

            if (rows * cols != numbers.Length && numbers.Length != 0)
            {
                throw new ArgumentException();
            }

            matrix = new int[rows, cols];
            Rows = rows;
            Cols = cols;

            if (numbers.Length > 0)
            {
                Buffer.BlockCopy(numbers, 0, matrix, 0, rows * cols * sizeof(int));
            }
        }

        private int this[int row, int col]
        {
            get { return matrix[row, col]; }
            set { matrix[row, col] = value; }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int row = 0; row < this.Rows; row++)
            {

                for (int col = 0; col < this.Cols; col++)
                {
                    result.AppendFormat("{0,4}", matrix[row, col]);
                }

                result.AppendLine();
            }

            return result.ToString();
        }

        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols)
            {
                Console.WriteLine("Matrices must be of the same type.");
                return null;
            }

            Matrix sum = new Matrix(matrix1.Rows, matrix1.Cols);
            for (int row = 0; row < sum.Rows; row++)
            {

                for (int col = 0; col < sum.Cols; col++)
                {

                    sum[row, col] = matrix1[row, col] + matrix2[row, col];
                }
            }
            return sum;
        }

        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols)
            {
                Console.WriteLine("Matrices must be of the same type.");
                return null;
            }

            Matrix minus = new Matrix(matrix1.Rows, matrix1.Cols);
            for (int row = 0; row < minus.Rows; row++)
            {
                for (int col = 0; col < minus.Cols; col++)
                {
                    minus[row, col] = matrix1[row, col] - matrix2[row, col];
                }
            }

            return minus;
        }

        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            Matrix product = new Matrix(matrix1.Rows, matrix2.Cols);
            for (int row = 0; row < product.Rows; row++)
            {

                for (int col = 0; col < product.Cols; col++)
                {

                    for (int k = 0; k < matrix1.Cols; k++) // or i < matrix2.Rows
                    {
                        product[row, col] += matrix1[row, k] * matrix2[k, col];
                    }
                }
            }
            return product;
        }
    }
}