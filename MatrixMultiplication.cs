using System;

class MatrixMultiplication
{
    static void Main()
    {
        int i, j, k;
        int r1, c1, r2, c2;

        Console.Write("Input the rows and columns of first matrix : ");
        r1 = Convert.ToInt32(Console.ReadLine());
        c1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the rows and columns of second matrix : ");
        r2 = Convert.ToInt32(Console.ReadLine());
        c2 = Convert.ToInt32(Console.ReadLine());

        int[,] matrix1 = new int[r1, c1];
        int[,] matrix2 = new int[r2, c2];
        int[,] result = new int[r1, c2];

        Console.WriteLine("Input elements in the first matrix :");
        for (i = 0; i < r1; i++)
        {
            for (j = 0; j < c1; j++)
            {
                Console.Write($"element - [{i}],[{j}] : ");
                matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Input elements in the second matrix :");
        for (i = 0; i < r2; i++)
        {
            for (j = 0; j < c2; j++)
            {
                Console.Write($"element - [{i}],[{j}] : ");
                matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Matrix Multiplication
        for (i = 0; i < r1; i++)
        {
            for (j = 0; j < c2; j++)
            {
                result[i, j] = 0;
                for (k = 0; k < c1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        Console.WriteLine("\nThe First matrix is :");
        for (i = 0; i < r1; i++)
        {
            for (j = 0; j < c1; j++)
            {
                Console.Write(matrix1[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nThe Second matrix is :");
        for (i = 0; i < r2; i++)
        {
            for (j = 0; j < c2; j++)
            {
                Console.Write(matrix2[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nThe multiplication of two matrix is :");
        for (i = 0; i < r1; i++)
        {
            for (j = 0; j < c2; j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}